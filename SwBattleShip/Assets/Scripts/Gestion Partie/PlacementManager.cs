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

            PolygonCollider2D[] boxParentTemp = ships.GetComponents<PolygonCollider2D>();

            foreach (PolygonCollider2D boxP in boxParentTemp)
            {
                boxP.enabled = false;
            }

            Destroy(ships.GetComponent<DraggingShip>());

            Destroy(ships.GetComponent<Rigidbody2D>());

            Renderer[] cache = ships.GetComponents<Renderer>();

            foreach (Renderer rd in cache)
            {
                rd.enabled = false;
            }
        }
    }
}
