// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PipeTile : MonoBehaviour
// {
//     public enum Direction { Up, Right, Down, Left }

//     public Direction[] baseConnections;
//     public Direction[] currentConnections;

//     public Renderer pipeRenderer;
//     private Material[] instanceMaterials;

//     public Color energizedColor = Color.cyan;
//     public float glowIntensity = 1.5f;

//     private void Awake()
//     {
//         if (pipeRenderer == null)
//         {
//             Debug.LogError($"PipeTile {name}: pipeRenderer не назначен!");
//             return;
//         }

//         currentConnections = (Direction[])baseConnections.Clone();

//         instanceMaterials = pipeRenderer.materials;
//         if (instanceMaterials.Length <= 2)
//         {
//             Debug.LogWarning($"{name}: Материал для свечения не найден (materials.Length={instanceMaterials.Length})");
//         }
//         else
//         {
//             instanceMaterials[2] = new Material(instanceMaterials[2]);
//             pipeRenderer.materials = instanceMaterials;
//         }

//         ResetGlow();
//     }

//     private void OnMouseDown()
//     {
//         RotateTile();
//     }

//     public void RotateTile()
//     {
//         Transform parentTransform = transform.parent.parent;
//         parentTransform.Rotate(0f, 90f, 0f);

//         for (int i = 0; i < currentConnections.Length; i++)
//         {
//             currentConnections[i] = RotateDirectionRight(currentConnections[i]);
//         }
//     }

//     private Direction RotateDirectionRight(Direction dir)
//     {
//         switch (dir)
//         {
//             case Direction.Up: return Direction.Right;
//             case Direction.Right: return Direction.Down;
//             case Direction.Down: return Direction.Left;
//             case Direction.Left: return Direction.Up;
//             default: return dir;
//         }
//     }

//     public bool HasConnection(Direction dir)
//     {
//         foreach (Direction d in currentConnections)
//         {
//             if (d == dir) return true;
//         }
//         return false;
//     }

//     public void Energize()
//     {
//         instanceMaterials[2].EnableKeyword("_EMISSION");

//         instanceMaterials[2].SetColor("_EmissionColor", Color.black);

//         instanceMaterials[2].SetColor("_EmissionColor", energizedColor * glowIntensity);

//         instanceMaterials[2].EnableKeyword("_EMISSION");
//     }

//     public void ResetGlow()
//     {
//         instanceMaterials[2].SetColor("_EmissionColor", Color.black);
//         instanceMaterials[2].DisableKeyword("_EMISSION");
//     }

//     public void ResetTile()
//     {
//         ResetGlow();
//         transform.rotation = Quaternion.identity;

//         currentConnections = (Direction[])baseConnections.Clone();

//         DebugConnections();
//     }

//     public void DebugConnections()
//     {
//         string conns = "";
//         foreach (var c in currentConnections)
//         {
//             conns += c.ToString() + " ";
//         }
//         Debug.Log($"{name} connections: {conns}");
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTile : MonoBehaviour
{
    public enum Direction { Up, Right, Down, Left }

    public Direction[] baseConnections;
    public Direction[] currentConnections;

    public bool isActivated = false;

    public Renderer pipeRenderer;
    private Material[] instanceMaterials;

    public Color energizedColor = Color.cyan;
    public float glowIntensity = 1.5f;

    private void Awake()
    {
        if (pipeRenderer == null)
        {
            Debug.LogError($"PipeTile {name}: pipeRenderer не назначен!");
            return;
        }

        currentConnections = (Direction[])baseConnections.Clone();

        instanceMaterials = pipeRenderer.materials;
        if (instanceMaterials.Length <= 2)
        {
            Debug.LogWarning($"{name}: Материал для свечения не найден (materials.Length={instanceMaterials.Length})");
        }
        else
        {
            instanceMaterials[2] = new Material(instanceMaterials[2]);
            pipeRenderer.materials = instanceMaterials;
        }

        ResetGlow();
    }

    private void OnMouseDown()
    {
        RotateTile();
    }

    public void RotateTile()
    {
        Transform parentTransform = transform.parent.parent;
        parentTransform.Rotate(0f, 90f, 0f);

        for (int i = 0; i < currentConnections.Length; i++)
        {
            currentConnections[i] = RotateDirectionRight(currentConnections[i]);
        }
    }

    private Direction RotateDirectionRight(Direction dir)
    {
        switch (dir)
        {
            case Direction.Up: return Direction.Right;
            case Direction.Right: return Direction.Down;
            case Direction.Down: return Direction.Left;
            case Direction.Left: return Direction.Up;
            default: return dir;
        }
    }

    public bool HasConnection(Direction dir)
    {
        foreach (Direction d in currentConnections)
        {
            if (d == dir) return true;
        }
        return false;
    }

    public void Energize()
    {
        if (gameObject.CompareTag("Winner"))
        {
            isActivated = true;
        }

        instanceMaterials[2].EnableKeyword("_EMISSION");

        instanceMaterials[2].SetColor("_EmissionColor", Color.black);

        instanceMaterials[2].SetColor("_EmissionColor", energizedColor * glowIntensity);

        instanceMaterials[2].EnableKeyword("_EMISSION");
    }

    public void ResetGlow()
    {
        instanceMaterials[2].SetColor("_EmissionColor", Color.black);
        instanceMaterials[2].DisableKeyword("_EMISSION");
    }

    public void ResetTile()
    {
        ResetGlow();
        transform.parent.parent.rotation = Quaternion.identity;

        currentConnections = (Direction[])baseConnections.Clone();

        DebugConnections();
    }

    public void DebugConnections()
    {
        string conns = "";
        foreach (var c in currentConnections)
        {
            conns += c.ToString() + " ";
        }
        Debug.Log($"{name} connections: {conns}");
    }
}