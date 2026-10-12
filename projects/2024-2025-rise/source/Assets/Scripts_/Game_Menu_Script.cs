using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Game_Menu_Script : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject canvas_game_menu;
    public GameObject canvas_pause_menu;
    public GameObject canvas_end_game;
    public GameObject death_canvas;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite s6;
    public Sprite s7;
    public Sprite s8;
    public Sprite s9;
    public Sprite s10;
    public Sprite s11;
    public Sprite s12;
    public Sprite s13;
    public Sprite s14;
    public Sprite s15;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject v5;
    public GameObject v6;
    public GameObject v7;
    public GameObject v8;
    public GameObject v9;
    public GameObject ssword;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("IsIt2") == 1)
        {
            ssword.SetActive(true);
            PlayerPrefs.SetInt("IsIt2", 0);
        }
        else
        {
            ssword.SetActive(false);
        }
        if(PlayerPrefs.GetInt("sk1") == 1)
        {
            spriteRenderer.sprite = s1;
        }
        if(PlayerPrefs.GetInt("sk2") == 1)
        {
            spriteRenderer.sprite = s2;
        }
        if(PlayerPrefs.GetInt("sk3") == 1)
        {
            spriteRenderer.sprite = s3;
        }
        if(PlayerPrefs.GetInt("sk4") == 1)
        {
            spriteRenderer.sprite = s4;
        }
        if(PlayerPrefs.GetInt("sk5") == 1)
        {
            spriteRenderer.sprite = s5;
        }
        if(PlayerPrefs.GetInt("sk6") == 1)
        {
            spriteRenderer.sprite = s6;
        }
        if(PlayerPrefs.GetInt("sk7") == 1)
        {
            spriteRenderer.sprite = s7;
        }
        if(PlayerPrefs.GetInt("sk8") == 1)
        {
            spriteRenderer.sprite = s8;
        }
        if(PlayerPrefs.GetInt("sk9") == 1)
        {
            spriteRenderer.sprite = s9;
        }
        if(PlayerPrefs.GetInt("sk10") == 1)
        {
            spriteRenderer.sprite = s10;
        }
        if(PlayerPrefs.GetInt("sk11") == 1)
        {
            spriteRenderer.sprite = s11;
        }if(PlayerPrefs.GetInt("sk12") == 1)
        {
            spriteRenderer.sprite = s12;
        }
        if(PlayerPrefs.GetInt("sk13") == 1)
        {
            spriteRenderer.sprite = s13;
        }
        if(PlayerPrefs.GetInt("sk14") == 1)
        {
            spriteRenderer.sprite = s14;
        }
        if(PlayerPrefs.GetInt("sk15") == 1)
        {
            spriteRenderer.sprite = s15;
        }
        if(PlayerPrefs.GetInt("tr1") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr2") == 1)
        {
            v2.SetActive(true);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr3") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(true);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr4") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(true);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr5") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(true);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr6") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(true);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr7") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(true);
            v8.SetActive(false);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr8") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(true);
            v9.SetActive(false);
        }
        if(PlayerPrefs.GetInt("tr9") == 1)
        {
            v2.SetActive(false);
            v3.SetActive(false);
            v4.SetActive(false);
            v5.SetActive(false);
            v6.SetActive(false);
            v7.SetActive(false);
            v8.SetActive(false);
            v9.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PauseMenu()
    {
        canvas_game_menu.SetActive(false);
        canvas_pause_menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void BacktoGame()
    {
        canvas_game_menu.SetActive(true);
        canvas_pause_menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void BacktoHomeMenu()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("IsIt1", 0);
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene().buildIndex != 24)
        {
            PlayerPrefs.SetInt("IsIt1", 0);
            canvas_end_game.SetActive(false);
            canvas_game_menu.SetActive(true);
            canvas_pause_menu.SetActive(false);
            death_canvas.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
    public void PreviousLevel()
    {
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            PlayerPrefs.SetInt("IsIt1", 0);
            canvas_end_game.SetActive(false);
            canvas_game_menu.SetActive(true);
            canvas_pause_menu.SetActive(false);
            death_canvas.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        
    }
    public void Restart()
    {
        PlayerPrefs.SetInt("IsIt1", 0);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        canvas_end_game.SetActive(false);
        canvas_game_menu.SetActive(true);
        canvas_pause_menu.SetActive(false);
        death_canvas.SetActive(false);
    }
    
}
