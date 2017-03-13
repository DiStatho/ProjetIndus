using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterManager : MonoBehaviour {

    private Collider2D caseVide;
    private bool isTrigerred = false;

    private void Start()
    {
        caseVide = gameObject.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTrigerred = true;
    }

    private void OnMouseDown()
    {
        Debug.Log("Raté !!");

        caseVide.enabled = false;
    }
}
