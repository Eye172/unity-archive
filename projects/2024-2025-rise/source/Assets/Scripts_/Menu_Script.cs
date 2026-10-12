using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu_Script : MonoBehaviour
{
    [SerializeField] GameObject canvas_menu;
    [SerializeField] GameObject canvas_level_map;
    [SerializeField] GameObject canvas_locker_1;
    [SerializeField] GameObject canvas_locker_2;
    [SerializeField] GameObject canvas_store;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenLevelMap()
    {
        PlayerPrefs.SetInt("IsIt1", 0);
        canvas_menu.SetActive(false);
        canvas_level_map.SetActive(true);
    }
    public void BacktoMenu()
    {
        canvas_menu.SetActive(true);
        canvas_level_map.SetActive(false);
        canvas_locker_1.SetActive(false);
        canvas_locker_2.SetActive(false);
        canvas_store.SetActive(false);
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OpenLocker1()
    {
        canvas_menu.SetActive(false);
        canvas_level_map.SetActive(false);
        canvas_locker_1.SetActive(true);
        canvas_locker_2.SetActive(false);
        canvas_store.SetActive(false);
    }
    public void OpenLocker2()
    {
        canvas_menu.SetActive(false);
        canvas_level_map.SetActive(false);
        canvas_locker_1.SetActive(false);
        canvas_locker_2.SetActive(true);
        canvas_store.SetActive(false);
    }
    public void OpenStore()
    {
        canvas_menu.SetActive(false);
        canvas_level_map.SetActive(false);
        canvas_locker_1.SetActive(false);
        canvas_locker_2.SetActive(false);
        canvas_store.SetActive(true);
    }
    
    public void OpenLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void OpenLevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void OpenLevel4()
    {
        SceneManager.LoadScene(4);
    }
    public void OpenLevel5()
    {
        SceneManager.LoadScene(5);
    }
    public void OpenLevel6()
    {
        SceneManager.LoadScene(6);
    }
    public void OpenLevel7()
    {
        SceneManager.LoadScene(7);
    }
    public void OpenLevel8()
    {
        SceneManager.LoadScene(8);
    }
    public void OpenLevel9()
    {
        SceneManager.LoadScene(9);
    }
    public void OpenLevel10()
    {
        SceneManager.LoadScene(10);
    }
    public void OpenLevel11()
    {
        SceneManager.LoadScene(11);
    }
    public void OpenLevel12()
    {
        SceneManager.LoadScene(12);
    }
    public void OpenLevel13()
    {
        SceneManager.LoadScene(13);
    }
    public void OpenLevel14()
    {
        SceneManager.LoadScene(14);
    }
    public void OpenLevel15()
    {
        SceneManager.LoadScene(15);
    }
    public void OpenLevel16()
    {
        SceneManager.LoadScene(16);
    }
    public void OpenLevel17()
    {
        SceneManager.LoadScene(17);
    }
    public void OpenLevel18()
    {
        SceneManager.LoadScene(18);
    }
    public void OpenLevel19()
    {
        SceneManager.LoadScene(19);
    }
    public void OpenLevel20()
    {
        SceneManager.LoadScene(20);
    }
    public void OpenLevel21()
    {
        SceneManager.LoadScene(21);
    }
    public void OpenLevel22()
    {
        SceneManager.LoadScene(22);
    }
    public void OpenLevel23()
    {
        SceneManager.LoadScene(23);
    }
    public void OpenLevel24()
    {
        SceneManager.LoadScene(24);
    }
    
}
