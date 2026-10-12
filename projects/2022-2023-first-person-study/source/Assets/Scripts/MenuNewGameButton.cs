using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNewGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void new_game_button()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        
    }
}
