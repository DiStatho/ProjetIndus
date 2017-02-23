using UnityEngine.UI;
using UnityEngine;

public class Setting : MonoBehaviour {

	private static bool musicActive=true, soundActive=true;
	public Toggle musicToggle,soundToggle;
	public Slider musicSlider, soundSlider;

	// Use this for initialization
	void Start () {
		/*GameObject.Find ("TextSolo").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("PVE");
		GameObject.Find ("TextPvp").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("PVP");
		GameObject.Find ("TextPropos").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("credit");
		GameObject.Find ("TextReglages").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("settings");

		*/
		//GameObject.Find ("Son").GetComponent<Text> ().text = Global.jsonReader.ReadValue ("sound");
		/*musicToggle.isOn = musicActive;
		soundToggle.isOn = soundActive;
		print ("sound "+soundActive);

		print ("music "+musicActive);

*/
	}

	public void ChangeState(){
		/*
		soundActive = soundToggle.isOn;
		print ("sound "+soundActive);
		musicActive = musicToggle.isOn;
		print ("music "+musicActive);

		//soundSlider.gameObject.SetActive (soundActive);
		//musicSlider.gameObject.SetActive (musicActive);
		*/
	}
	

}
