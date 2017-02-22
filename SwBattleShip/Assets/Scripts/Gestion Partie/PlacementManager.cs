using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour {

    public List<GameObject> ListeVaisseaux = new List<GameObject>();

    public void swapCollider()
    {
        foreach (GameObject ships in ListeVaisseaux)
        {
            BoxCollider2D[] boxChildTemp = ships.GetComponentsInChildren<BoxCollider2D>(true);

            foreach (BoxCollider2D boxC in boxChildTemp)
            {
                boxC.enabled = true;
            }

            BoxCollider2D[] boxParentTemp = ships.GetComponents<BoxCollider2D>();

            foreach(BoxCollider2D boxP in boxParentTemp)
            {
                boxP.enabled = false;
            }
        }
    }
}
