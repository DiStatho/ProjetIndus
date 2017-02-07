using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipBehavior : MonoBehaviour {

    public int nbBoxCollider = 2;

    public void estTouche()
    {
        nbBoxCollider--;

        if (nbBoxCollider == 0)
        {
            Debug.Log("Coulé ! " + gameObject.name);
        }
    }
}
