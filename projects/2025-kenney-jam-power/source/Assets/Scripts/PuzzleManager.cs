// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PuzzleManager : MonoBehaviour
// {
//     public PipeTile startTile;
//     public PipeTile.Direction startDirection;

//     private List<PipeTile> energizedTiles = new List<PipeTile>();

//     public void StartEnergyFlow()
//     {
//         ResetAllTiles();
//         StartCoroutine(FlowEnergy(startTile, startDirection));
//     }

//     private IEnumerator FlowEnergy(PipeTile tile, PipeTile.Direction fromDirection)
//     {
//         tile.Energize();
//         energizedTiles.Add(tile);
//         yield return new WaitForSeconds(0.2f);

//         foreach (PipeTile.Direction dir in tile.currentConnections)
//         {
//             if (dir == OppositeDirection(fromDirection))
//             {
//                 Debug.Log($"Skipping direction {dir} because it's opposite to the incoming direction {fromDirection}");
//                 continue;
//             }

//             Vector3 neighborPos = GetNeighborPosition(tile.transform.position, dir);
//             Debug.Log($"Checking neighbor at {neighborPos} from direction {dir}");

//             // Найдем соседа по вычисленной позиции
//             PipeTile neighbor = FindPipeAtPosition(neighborPos);

//             if (neighbor == null)
//             {
//                 Debug.LogWarning($"No neighbor found at position {neighborPos}");
//                 continue;
//             }

//             // Логируем текущие соединения соседа
//             string neighborConns = "";
//             foreach (var c in neighbor.currentConnections)
//             {
//                 neighborConns += c.ToString() + " ";
//             }
//             Debug.Log($"Neighbor {neighbor.name} connections: {neighborConns}");

//             PipeTile.Direction expectedDir = OppositeDirection(dir);
//             Debug.Log($"Expected neighbor connection direction: {expectedDir}");

//             // Теперь проверяем, соответствует ли соединение соседнего элемента
//             bool hasMatchingConnection = neighbor.HasConnection(expectedDir) || neighbor.HasConnection(dir);

//             if (hasMatchingConnection)
//             {
//                 Debug.Log($"Found matching neighbor: {neighbor.name} has connection {expectedDir} or {dir}");
//                 yield return StartCoroutine(FlowEnergy(neighbor, dir));
//             }
//             else
//             {
//                 Debug.LogWarning($"Neighbor {neighbor.name} has NO matching connection {expectedDir} or {dir}");
//             }
//         }
//     }

//     private void ResetAllTiles()
//     {
//         foreach (PipeTile tile in energizedTiles)
//         {
//             tile.ResetTile();
//         }
//         energizedTiles.Clear();
//     }

//     private Vector3 GetNeighborPosition(Vector3 current, PipeTile.Direction dir)
//     {
//         float step = 3f;
//         float height = -0.5f;

//         Vector3 offset = Vector3.zero;

//         switch (dir)
//         {
//             case PipeTile.Direction.Up: offset = new Vector3(0f, height, step); break;
//             case PipeTile.Direction.Right: offset = new Vector3(step, height, 0f); break;
//             case PipeTile.Direction.Down: offset = new Vector3(0f, height, -step); break;
//             case PipeTile.Direction.Left: offset = new Vector3(-step, height, 0f); break;
//         }

//         return current + offset;
//     }

//     private PipeTile FindPipeAtPosition(Vector3 pos)
//     {
//         Vector3 searchPos = new Vector3(pos.x, -0.5f, pos.z);
//         float searchRadius = 1f;
//         Collider[] hits = Physics.OverlapSphere(searchPos, searchRadius);

//         foreach (Collider hit in hits)
//         {
//             PipeTile tile = hit.GetComponent<PipeTile>();
//             if (tile != null)
//                 return tile;
//         }
//         return null;
//     }

//     private PipeTile.Direction OppositeDirection(PipeTile.Direction dir)
//     {
//         return (PipeTile.Direction)(((int)dir + 2) % 4);
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public PipeTile startTile; // Начальная плитка
    public PipeTile.Direction startDirection; // Направление для старта

    private List<PipeTile> energizedTiles = new List<PipeTile>();
    private HashSet<PipeTile> processedTiles = new HashSet<PipeTile>();

    public void StartEnergyFlow()
    {
        ResetAllTiles();
        processedTiles.Clear();
        StartCoroutine(FlowEnergy(startTile, startDirection));
    }

    private IEnumerator FlowEnergy(PipeTile tile, PipeTile.Direction fromDirection)
    {
        if (processedTiles.Contains(tile))
            yield break;

        tile.Energize();
        energizedTiles.Add(tile);
        processedTiles.Add(tile);
        yield return new WaitForSeconds(0.2f);

        foreach (PipeTile.Direction dir in tile.currentConnections)
        {
            if (dir == OppositeDirection(fromDirection))
            {
                Debug.Log($"Skipping direction {dir} because it's opposite to the incoming direction {fromDirection}");
                continue;
            }

            // Получаем позицию соседа относительно координат родителя
            Vector3 neighborPos = GetNeighborPosition(tile.transform.parent.parent.position, dir);
            Debug.Log($"Checking neighbor at {neighborPos} from direction {dir}");

            // Передаем родительский Transform в метод поиска соседа
            PipeTile neighbor = FindPipeAtPosition(neighborPos, tile.transform.parent.parent);

            if (neighbor != null)
            {
                Debug.Log($"Found neighbor: {neighbor.name} in direction {dir}");

                bool hasMatchingConnection = neighbor.HasConnection(OppositeDirection(dir));

                if (hasMatchingConnection)
                {
                    Debug.Log($"Found matching neighbor: {neighbor.name} has connection {OppositeDirection(dir)}");
                    yield return StartCoroutine(FlowEnergy(neighbor, dir));
                }
                else
                {
                    Debug.LogWarning($"Neighbor {neighbor.name} has NO matching connection {OppositeDirection(dir)}");
                }
            }
            else
            {
                Debug.LogWarning($"No neighbor found at position {neighborPos}");
            }
        }
    }

    private void ResetAllTiles()
    {
        foreach (PipeTile tile in energizedTiles)
        {
            tile.ResetTile();
        }
        energizedTiles.Clear();
    }

    private Vector3 GetNeighborPosition(Vector3 current, PipeTile.Direction dir)
    {
        float step = 3f;  // Шаг в 3 единицы по осям X и Z (расстояние между плитками)
        float height = 0f;  // Плитки лежат на одной высоте

        Vector3 offset = Vector3.zero;

        // Определяем смещения в зависимости от направления
        switch (dir)
        {
            case PipeTile.Direction.Up: offset = new Vector3(-step, height, 0f); break;  // Move Up (по X минус)
            case PipeTile.Direction.Down: offset = new Vector3(step, height, 0f); break;  // Move Down (по X плюс)
            case PipeTile.Direction.Left: offset = new Vector3(0f, height, -step); break;  // Move Left (по Z минус)
            case PipeTile.Direction.Right: offset = new Vector3(0f, height, step); break;  // Move Right (по Z плюс)
        }

        return current + offset;  // Возвращаем позицию соседа, ориентируясь на родителя
    }

    private PipeTile FindPipeAtPosition(Vector3 pos, Transform tileParent)
    {
        Vector3 searchPos = pos;  // Координаты для поиска
        float searchRadius = 0.5f;  // Радиус поиска для предотвращения самопоиска
        Collider[] hits = Physics.OverlapSphere(searchPos, searchRadius);

        foreach (Collider hit in hits)
        {
            PipeTile tile = hit.GetComponent<PipeTile>();
            if (tile != null && tile.transform.parent.parent.parent != tileParent) // Исключаем самопоиск
            {
                Debug.Log($"Found neighbor: {tile.name} at position {tile.transform.position}");
                return tile;
            }
        }

        Debug.LogWarning($"No neighbor found at position {pos}");
        return null;
    }

    private PipeTile.Direction OppositeDirection(PipeTile.Direction dir)
    {
        return (PipeTile.Direction)(((int)dir + 2) % 4);  // Получаем противоположное направление
    }
}
