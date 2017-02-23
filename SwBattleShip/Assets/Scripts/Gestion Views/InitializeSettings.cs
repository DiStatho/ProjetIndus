using UnityEngine.UI;
using UnityEngine;

public class InitializeSettings : MonoBehaviour {

	public Toggle sound, music;


	// Use this for initialization
	void Start () {
		sound.isOn = GlobalData.IsSoundcActive();
		music.isOn = GlobalData.IsMusicActive ();

		GameObject.Find ("Titre").GetComponent<Text> ().text = GlobalData.GetJsonReader ().ReadValue ("settings");
		GameObject.Find ("SoundLabel").GetComponent<Text> ().text = GlobalData.GetJsonReader ().ReadValue ("sound");
		GameObject.Find ("MusicLabel").GetComponent<Text> ().text = GlobalData.GetJsonReader ().ReadValue ("music");
		GameObject.Find ("BackButtonText").GetComponent<Text> ().text = GlobalData.GetJsonReader ().ReadValue ("back");
		GameObject.Find ("Langues").GetComponent<Dropdown> ().value = NumberLangage (GlobalData.GetCurrentLangage());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeState(){
		
	}

	private int NumberLangage(string langage){
		if (langage.Equals ("fr"))
			return 0;
		else
			return 1;
	}

	public void Reload(){
		Start ();
	}
}
