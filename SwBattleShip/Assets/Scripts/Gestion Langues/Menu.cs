using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {


	// Use this for initialization
	void Start () {
		GameObject.Find ("TextSolo").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("PVE");
		GameObject.Find ("TextPvp").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("PVP");
		GameObject.Find ("TextPropos").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("credit");
		GameObject.Find ("TextReglages").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("settings");
	}
	

}
