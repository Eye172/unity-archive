using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public skin[] skins;
    public GameObject last_skin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var j in skins)
        {
            if (!j.kuplenov)
                j.txt.text = "$ " + j.price;
            else
                j.txt.text = "Œ/Õ¿ƒ≈“‹";

            if (GetComponent<PlayerController>().Money>=j.price || j.kuplenov)
                j.btn.interactable  = true;
            else
                j.btn.interactable = false;

        }
    }

    public void click(int i)
    {
        last_skin.SetActive(false);
        last_skin = skins[i].obj;
        skins[i].obj.SetActive(true);

        if (!skins[i].kuplenov)
        {
            GetComponent<PlayerController>().ChangeMoney(-skins[i].price);
            skins[i].kuplenov = true;

        }
    
    }


}


[System.Serializable]
public class skin
{
    public int price;
    public GameObject obj;
    public Text txt;
    public Button btn;
    public bool kuplenov;

}
