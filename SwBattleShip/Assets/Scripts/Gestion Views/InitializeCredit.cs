using UnityEngine.UI;
using UnityEngine;

public class InitializeCredit : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject.Find ("Titre").GetComponent<Text> ().text = GlobalData.GetJsonReader().ReadValue ("credit");
		GameObject.Find ("Text").GetComponent<Text> ().text = GlobalData.GetJsonReader().ReadValue ("creditText");
		GameObject.Find ("BackButtonText").GetComponent<Text> ().text = GlobalData.GetJsonReader ().ReadValue ("back");

	}
	

}
