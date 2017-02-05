using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BoxColliderBehavior : MonoBehaviour {

    private BoxCollider2D colliderbox;

	void Start () {
        colliderbox = GetComponent<BoxCollider2D>();

        Physics.queriesHitTriggers = true;
    }

    // methode pour Pc...
    private void OnMouseDown()
    {
        Debug.Log("Touché ! " + gameObject.name);

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
                    colliderbox.enabled = false;
            }
        }
    }
}
