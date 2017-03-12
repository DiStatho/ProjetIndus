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

    public Grille laGrille;
    public GameObject col;
    private Transform caseHolder;

    void CaseVideSetup()
    {
        caseHolder = new GameObject("Cases").transform;

        for (int i = 0; i < laGrille.listLength(); i++)
        {
            GameObject _case = Instantiate(col, laGrille.getElemGrille(i), Quaternion.identity);

            _case.transform.SetParent(caseHolder);
        }
    }

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
        BackGroundSetUp();
        GridSetup();

        laGrille.initializationList();

        CaseVideSetup();
    }

}
