using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingShip : MonoBehaviour {

    float distance = 10;

    [SerializeField]
    private float deltaPlacement = 0;

    private float timerBeforeMoving = 0.5f;
    private bool isMoving = false;

    public Grille grid;
    public GameObject ship;

    private void Awake()
    {
        grid.initializationList();
    }

    public void calculVectorPlusProche()
    {
        Vector2 posShip = ship.transform.position;

        Vector2 posShipPlacer = posShip;

        float min = 1000000;
        float dist;

        for (int i = 0; i < grid.listLength() ; i++)
        {
            dist = Vector2.Distance(posShip, grid.getElemGrille(i));

            if (dist < min)
            {
                min = dist;

                posShipPlacer = grid.getElemGrille(i);
            }
        }

        if (ship.transform.rotation.eulerAngles.z == 0 || ship.transform.rotation.eulerAngles.z == 180)
            posShipPlacer.x += deltaPlacement;
        else
            posShipPlacer.y += deltaPlacement;

        placerVaisseau(posShipPlacer);
    }

    public void placerVaisseau(Vector3 vector)
    {
        ship.transform.position = vector;
    }

    // methode pour Pc...
    private void OnMouseDrag()
    {
        timerBeforeMoving -= Time.deltaTime;

        if (timerBeforeMoving <= 0)
            isMoving = true;

        if (isMoving)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(position);
            transform.position = objPosition;
        }
    }

    // methode pour Pc...
    private void OnMouseUp()
    {
        if (isMoving)
        {
            calculVectorPlusProche();

            isMoving = false;
        }
        else
        {
            ship.transform.Rotate(0, 0, 90);
            ship.transform.Translate(-deltaPlacement, -deltaPlacement, 0);
        }

        timerBeforeMoving = 0.5f;
    }

    // methode android 
 /*   void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector2 deltaPosition = Input.GetTouch(0).deltaPosition;
            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    break;

                case TouchPhase.Moved:
                    timerBeforeMoving -= Time.deltaTime;

                    if (timerBeforeMoving <= 0)
                        isMoving = true;

                    if (isMoving)
                    {
                        Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
                        Vector3 objPosition = Camera.main.ScreenToWorldPoint(position);
                        transform.position = objPosition;
                    }
                    break;

                case TouchPhase.Ended:
                    if (isMoving)
                    {
                        calculVectorPlusProche();

                        isMoving = false;
                    }
                    else
                    {
                        ship.transform.Rotate(0, 0, 90);
                        ship.transform.Translate(-deltaPlacement, -deltaPlacement, 0);
                    }

                    timerBeforeMoving = 1.0f;
                    break;
            }
        }
    } */
}

