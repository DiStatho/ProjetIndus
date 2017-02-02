using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    private string LaPutainDeTaMere;

    void Start () {
        LaPutainDeTaMere = "SOUETANE A MOUK !";
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Debug.Log(LaPutainDeTaMere);
	}
}
