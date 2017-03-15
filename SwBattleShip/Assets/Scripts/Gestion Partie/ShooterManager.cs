using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterManager : MonoBehaviour {

    private Collider2D caseVide;
    private bool isTrigerred = false;
    private bool shootable = false;
    public GameObject cross;

    private void Start()
    {
        caseVide = gameObject.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTrigerred = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTrigerred = false;
    }

    // methode PC...
    private void OnMouseDown()
    {
        if (shootable)
        {
            Debug.Log("Raté !!");

            caseVide.enabled = false;

            Instantiate(cross, caseVide.transform.position, Quaternion.identity);
        }
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
                if (hit.collider == caseVide)
                {
                    Debug.Log("Raté !!");

                    caseVide.enabled = false;

                    Instantiate(cross, caseVide.transform.position, Quaternion.identity);
                }
            }
        }
    }

    public bool getIsTrigerred()
    {
        return isTrigerred;
    }

    public Collider2D getCaseVide()
    {
        return caseVide;
    }

    public void setShootableTrue()
    {
        shootable = true;
    }
}
