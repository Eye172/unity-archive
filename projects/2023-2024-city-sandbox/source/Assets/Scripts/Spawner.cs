
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] float radius = 10;
    [SerializeField] float cooldown = 0.1f;
    
    private float timer = 0;
    
    void Start()
    {
        StartCoroutine(WaitAndPrint());
        GameObject buf = Instantiate(prefab);
        float x = Random.Range(-10, 10);
        float z = Random.Range(-10, 10);
        buf.transform.position = transform.position + new Vector3(x, 1, z);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown)
        {
            timer = 0;
            GameObject buf = Instantiate(prefab);
            float x = Random.Range(-radius, radius);
            float z = Random.Range(-radius, radius);
            buf.transform.position = transform.position + new Vector3(x, 1, z);
        }

        if (Input.GetKey(KeyCode.X))
        {
            GameObject buf = Instantiate(prefab);
            float x = Random.Range(-radius, radius);
            float z = Random.Range(-radius, radius);
            buf.transform.position = transform.position + new Vector3(x, 1, z);
        }
    }

    private IEnumerator WaitAndPrint()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            //print("Корутина выполняется и ждет " + Time.time);
            GameObject buf = Instantiate(prefab);
            float x = Random.Range(-radius, radius);
            float z = Random.Range(-radius, radius);
            buf.transform.position = transform.position + new Vector3(x, 1, z);

        }
    }

}