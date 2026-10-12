using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    public GameObject player;
    public Camera mainCamera; // Основная камера
    public Camera puzzleCamera; // Камера для головоломки
    public Canvas gameCanvas; // Канвас для игры
    public Canvas puzzleCanvas; // Канвас для головоломки
    public Slider timeSlider; // Слайдер для отображения времени
    public Text timeText; // Текст для отображения времени
    public PipeTile targetTile; // Плитка для победы

    private bool isPlayerInRange = false; // Находится ли игрок рядом с объектом
    private bool isCharging = false; // Состояние зарядки
    private bool puzzleStarted = false; // Старт головоломки

    private float totalTime = 0f; // Общее время на решение головоломки
    private float timeRemaining = 0f; // Оставшееся время

    private EnergySystem energySystem; // Система энергии игрока
    private bool isEnergyBeingDrained = false; // Процесс забора энергии

    private float energyDrained = 0f; // Количество забранной энергии

    void Start()
    {
        energySystem = GameObject.FindWithTag("Player").GetComponent<EnergySystem>();
        puzzleCanvas.gameObject.SetActive(false); // Скрыть PuzzleCanvas в начале
    }

    void Update()
    {
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))  // Если игрок нажимает E
            {
                StartCharging();  // Начинаем зарядку
            }

            if (isCharging)  // Если зарядка идет
            {
                if (Input.GetKey(KeyCode.E))  // Если E удерживается
                {
                    if (!isEnergyBeingDrained)
                    {
                        StartCoroutine(DrainEnergyForPuzzle());  // Начинаем забрать энергию
                    }
                }
                else  // Если E отпущена
                {
                    StopEnergyDrain();  // Останавливаем забор энергии
                }
            }
        }
    }

    // Старт зарядки и начало забора энергии
    void StartCharging()
    {
        if (energySystem.HasEnergy())
        {
            isCharging = true;
            isEnergyBeingDrained = false;
            energyDrained = 0f;
            timeRemaining = 0f;
            totalTime = 0f;

            StartCoroutine(DrainEnergyForPuzzle());  // Запускаем корутину забор энергии
        }
    }

    // Корутина для забора энергии каждые 2 секунды
    IEnumerator DrainEnergyForPuzzle()
    {
        isEnergyBeingDrained = true;
        while (isCharging && energySystem.currentEnergy > 0f)
        {
            energySystem.DrainEnergy(0.5f);
            energyDrained += 0.5f;  // Увеличиваем количество забранной энергии
            totalTime += 1f;  // Даем 30 секунд на решение головоломки
            timeRemaining += 1f;  // Увеличиваем оставшееся время
            timeSlider.maxValue = totalTime;
            timeSlider.value = timeRemaining;

            // Обновляем текст с временем
            float percentage = (timeRemaining / totalTime) * 100;
            timeText.text = Mathf.Ceil(percentage).ToString("F0") + "%";

            yield return new WaitForSeconds(0.1f);  // Забираем энергию каждые 2 секунды
        }

        isEnergyBeingDrained = false;

        // После окончания забора энергии, ждем 1 секунду
        yield return new WaitForSeconds(1f);

        // Начинаем второй этап
        StartPuzzle();
    }

    // Останавливаем забор энергии, если E отпущена
    void StopEnergyDrain()
    {
        isCharging = false;  // Останавливаем зарядку
        StopAllCoroutines();  // Останавливаем все корутины (в том числе DrainEnergyForPuzzle)

        // Если процесс забор энергии был остановлен, ждем 1 секунду и начинаем второй этап
        StartCoroutine(WaitForPuzzleStart());
    }

    // Корутина, которая ждет 1 секунду перед началом паззла
    IEnumerator WaitForPuzzleStart()
    {
        yield return new WaitForSeconds(1f);  // Ждем 1 секунду после того как отпустили E

        // Переход ко второму этапу
        StartPuzzle();
    }

    // Начало головоломки
    void StartPuzzle()
    {
        isCharging = false;
        puzzleStarted = true;  // Начинаем пазл

        // Переключаем камеру на камеру головоломки
        SwitchToPuzzleCamera();

        puzzleCanvas.gameObject.SetActive(true);  // Включаем PuzzleCanvas
        gameCanvas.gameObject.SetActive(false);  // Выключаем GameCanvas

        // Отключаем объект игрока для головоломки
        player.SetActive(false);

        // Начинаем новый таймер на основе забранной энергии
        StartCoroutine(PuzzleTimer());
    }

    // Корутина для таймера головоломки
    IEnumerator PuzzleTimer()
    {
        while (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  // Уменьшаем оставшееся время
            timeSlider.value = timeRemaining;  // Обновляем слайдер
            float percentage = (timeRemaining / totalTime) * 100;
            timeText.text = Mathf.Ceil(percentage).ToString("F0") + "%";  // Обновляем текст

            // Проверяем условие победы
            CheckPuzzleProgress();

            yield return null;  // Ждем следующий кадр
        }

        // Если время истекло, завершаем
        if (timeRemaining <= 0)
        {
            EndPuzzleStage();
            Debug.Log("Time's up!");  // Время закончилось, проигрыш
        }
    }

    void EndPuzzleStage()
    {
        isCharging = false;

        // Переключаем камеру на основную камеру
        SwitchToMainCamera();

        puzzleCanvas.gameObject.SetActive(false);  // Выключаем PuzzleCanvas
        gameCanvas.gameObject.SetActive(true);  // Включаем GameCanvas

        // Включаем объект игрока обратно
        player.SetActive(true);

        // Вставить условие "успеха", если головоломка решена
        if (targetTile != null && targetTile.GetComponent<Renderer>().material.GetColor("_EmissionColor") == new Color(170f / 255f, 255f / 255f, 255f / 255f))
        {
            Debug.Log("// WIN WIN");
        }
        else
        {
            Debug.Log("Time's up!");  // Время закончилось, проигрыш
        }
    }

    void SwitchToPuzzleCamera()
    {
        mainCamera.gameObject.SetActive(false);  // Отключаем основную камеру
        puzzleCamera.gameObject.SetActive(true);  // Включаем камеру головоломки
    }

    void SwitchToMainCamera()
    {
        mainCamera.gameObject.SetActive(true);  // Включаем основную камеру
        puzzleCamera.gameObject.SetActive(false);  // Отключаем камеру головоломки
    }

    void CheckPuzzleProgress()
    {
        if (targetTile != null && targetTile.GetComponent<PipeTile>() != null)
        {
            PipeTile pipeTile = targetTile.GetComponent<PipeTile>(); // Получаем компонент PipeTile

            // Проверяем, активирован ли флаг победы
            if (pipeTile.isActivated)
            {
                EndPuzzleStage();
                Debug.Log("// WIN WIN");  // Если головоломка решена успешно
                gameObject.SetActive(false);  // Отключаем объект
            }
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Если игрок входит в триггер
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  // Если игрок выходит из триггера
        {
            isPlayerInRange = false;
        }
    }
}
