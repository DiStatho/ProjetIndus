using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionContour : MonoBehaviour {

    [SerializeField]
    private float deltaPlacement = 0;

    public DraggingShip toReplace;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("contour"))
        {
            gameObject.transform.Rotate(0, 0, 90);

            toReplace.calculVectorPlusProche();
        }
    }
}
