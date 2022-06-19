using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    [SerializeField] private int width, height;
    [SerializeField] private Tile tiles;
    [SerializeField] private Transform cam;




    [SerializeField] private List<Tile> tilesList;

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var spawnTile = Instantiate(tiles, new Vector2(i, j), Quaternion.identity);
                spawnTile.name = $"{i}{j}";

                var selAlternate = (i % 2 == 0 && j % 2 != 0) || (j % 2 == 0 && i % 2 != 0);
                spawnTile.Init(selAlternate);
            }
        }

        cam.transform.position = new Vector3((float)width/2 - 0.5f, (float)height/2 - 0.5f, -10);
    
    }
}
