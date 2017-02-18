using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {


    public int rows = 12;
    public int columns = 19;
    public float ecart = 0.1f;

    public float centerRows = 0;
    public float centerColumns = 0;

    public GameObject[] backgrounds;
    public GameObject grid;

    private Transform boardHolder;

    // private List<Vector3> gridPositions = new List<Vector3>();

    /*
    void InitializationList()
    {
        gridPositions.Clear ();
            
        for(int x = 1; x<columns-1; x++)
        {
            for(int y = 1; y<rows-1; y++)
            {
                gridPositions.Add (new Vector3(x, y, 0f));
            }
        }
    }
    */

    void BackGroundSetUp()
    {
        GameObject toInstantiate = backgrounds[Random.Range(0, backgrounds.Length)];

        Instantiate(toInstantiate, new Vector3(0, 0, 0f), Quaternion.identity);
    }

    void GridSetup()
    {

        boardHolder = new GameObject("Board").transform;

        for (int x = 0; x < columns; x++)
        {
            GameObject grille = Instantiate(grid, new Vector3(x * ecart - centerColumns, 0, 0f), Quaternion.Euler(new Vector3(0,0,-90)));

            grille.transform.SetParent(boardHolder);
        }
        
        for (int y = 0; y < rows; y++)
        {
            GameObject grille = Instantiate(grid, new Vector3(-3.5f, y * ecart - centerRows, 0f), Quaternion.identity);

            grille.transform.SetParent(boardHolder);
        }
    }

    public void SetupScene()
    {
        // InitializationList();

        BackGroundSetUp();
        GridSetup();
    }

}
