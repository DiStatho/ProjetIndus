using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reglage : MonoBehaviour {
    public Toggle toggleSon,toggleMusique;
	// Use this for initialization
	void Start () {
		
	}
	
	public void setActive(Slider slidebar)
    {
        if (slidebar.CompareTag("Slider Son"))
            slidebar.gameObject.SetActive(toggleSon.isOn);
        if (slidebar.CompareTag("Slider Musique"))
            slidebar.gameObject.SetActive(toggleMusique.isOn);
    }

   
}
