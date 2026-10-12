using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Script : MonoBehaviour
{
    public bool pl_dead;
    public string scr;
    [SerializeField] Camera pl_camera;
    public GameObject canvas_game_menu;
    public GameObject canvas_pause_menu;
    public GameObject canvas_end_game;
    public GameObject death_canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        pl_dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pl_dead)
        {
            canvas_end_game.SetActive(false);
            canvas_game_menu.SetActive(false);
            canvas_pause_menu.SetActive(false);
            death_canvas.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<SpriteRenderer>().enabled = false;
            (pl_camera.GetComponent(scr) as MonoBehaviour).enabled = false;
            pl_dead = true;
        }
    }
}
