using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Script : Variables_
{
    public bool pl_win;
    public GameObject canvas_game_menu;
    public GameObject canvas_pause_menu;
    public GameObject canvas_end_game;
    public GameObject death_canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pl_win)
        {
            canvas_end_game.SetActive(true);
            canvas_game_menu.SetActive(false);
            canvas_pause_menu.SetActive(false);
            pl_win = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0f;
            pl_win = true;
            PlayerPrefs.SetInt("pl_gems", PlayerPrefs.GetInt("pl_gems") + 10);
            PlayerPrefs.Save();
        }
    }
}
