﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BoxColliderBehavior : MonoBehaviour {

    public SpaceShipBehavior spaceShip;

    private BoxCollider2D colliderbox;

    public GameObject explo;

	void Start () {
        colliderbox = GetComponent<BoxCollider2D>();

        Physics.queriesHitTriggers = true;

        this.GetComponent<BoxCollider2D>().enabled = false;

        this.enabled = false;
    }

    // methode pour Pc...
    private void OnMouseDown()
    {
        Debug.Log("Touché ! " + gameObject.name);

        spaceShip.estTouche();

        Instantiate(explo, colliderbox.transform.position, Quaternion.identity);

        colliderbox.enabled = false;
    }

    // methode pour android...
    private void Update()
    {
        foreach (Touch touche in Input.touches)
        {
            Ray ray = Camera.main.ScreenPointToRay(touche.position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider == colliderbox)
                {
                    Debug.Log("Touché ! " + gameObject.name);

                    spaceShip.estTouche();

                    Instantiate(explo, colliderbox.transform.position, Quaternion.identity);

                    colliderbox.enabled = false;
                }
            }
        }
    }
}
