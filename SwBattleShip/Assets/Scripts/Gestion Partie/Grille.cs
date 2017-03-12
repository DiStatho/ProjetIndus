using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grille : MonoBehaviour{

    private int nbColumns = 17;
    private int nbRows = 17;

    private List<Vector3> gridPositions = new List<Vector3>();

    public void initializationList()
    {
        gridPositions.Clear();

        for (float i = 0; i < nbColumns; i++)
        {
            for (float j = 0; j < nbRows; j++)
            {
                float y = -10.2f + (j * 1.2f);
                float x = -16 + (i * 1.2f);

                gridPositions.Add(new Vector3(x + 0.6f, y + 0.6f, 0f));
            }
        }
    }

    public void affiche()
    {
        Debug.Log(gridPositions.Count);

        for (int i = 0; i < gridPositions.Count; i++)
            Debug.Log(i + " " + gridPositions[i]);
    }

    public Vector3 getElemGrille(int index)
    {
        return gridPositions[index];
    }

    public int listLength()
    {
        return gridPositions.Count;
    }
}
