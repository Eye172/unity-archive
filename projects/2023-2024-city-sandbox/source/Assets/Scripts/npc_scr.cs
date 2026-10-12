using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class npc_scr : MonoBehaviour
{
   public DialgueNode[] node;
    [SerializeField] GameObject dialogue;
    [SerializeField] Text npc;
    [SerializeField] Text[] textButtons;
    [SerializeField] GameObject[] buttons;

    public int currentNode;


     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dialogue.SetActive(true);
            //currentNode = 0;
            Refresh();
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            dialogue.SetActive(false);
        }

        }


    public void click(int button)
    {
        if (node[currentNode].PlayerAnswer[button]._quest != null)
        {
            node[currentNode].PlayerAnswer[button]._quest.GetQuest();
        }

        if (node[currentNode].PlayerAnswer[button].SpeakEnd==true)
        {
            dialogue.SetActive(false);
          //  return;
        }

        currentNode = node[currentNode].PlayerAnswer[button].toNode;
        Refresh();

    }


    void Refresh()
    {
        npc.text = node[currentNode].Text;

        foreach (var j in buttons)
        {
            j.SetActive(false);
        }

        for (int i = 0; i < node[currentNode].PlayerAnswer.Length; i++)
        {
            buttons[i].SetActive(true);
            textButtons[i].text = node[currentNode].PlayerAnswer[i].Text;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class DialgueNode
{
    public string Text;
    public Answer[] PlayerAnswer;
}

[System.Serializable]
public class Answer
{
    public string Text;
    public int toNode;
    public bool SpeakEnd;
    public quest _quest;
}
