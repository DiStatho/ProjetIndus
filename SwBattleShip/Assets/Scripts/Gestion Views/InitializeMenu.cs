using UnityEngine.UI;
using UnityEngine;

public class InitializeMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GlobalData.SelectLangage ();
		GlobalData.SetFirstCheck (false);

		GameObject.Find ("TextSolo").GetComponent<Text> ().text = GlobalData.GetJsonReader().ReadValue ("PVE");
		GameObject.Find ("TextPvp").GetComponent<Text> ().text = GlobalData.GetJsonReader().ReadValue ("PVP");
		GameObject.Find ("TextPropos").GetComponent<Text> ().text = GlobalData.GetJsonReader().ReadValue ("credit");
		GameObject.Find ("TextReglages").GetComponent<Text> ().text = GlobalData.GetJsonReader().ReadValue ("settings");

	}


}
