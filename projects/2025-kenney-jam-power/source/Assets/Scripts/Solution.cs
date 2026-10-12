using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    void Start()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (var obj in allObjects)
        {
            if (obj.GetComponent<MeshRenderer>() == null) continue;

            Transform[] children = obj.GetComponentsInChildren<Transform>();

            foreach (var child in children)
            {
                if (child.childCount == 0)
                {
                    if (child.GetComponent<BoxCollider>() == null)
                    {
                        //BoxCollider boxCollider = child.gameObject.AddComponent<BoxCollider>();
                        //Debug.Log($"Добавлен BoxCollider к объекту: {child.name}");
                    }
                }
            }
        }
    }
}
