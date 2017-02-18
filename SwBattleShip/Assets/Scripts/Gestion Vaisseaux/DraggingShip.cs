using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingShip : MonoBehaviour {

    float distance = 10;

    private void OnMouseDrag()
    {
        Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(position);
        transform.position = objPosition;
    }
}
