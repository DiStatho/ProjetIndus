using UnityEngine.UI;
using UnityEngine;

public class Setting : MonoBehaviour {

	public Toggle toggleSound, toggleMusic;
	public Dropdown langage;
	// Use this for initialization
	void Start () {
		
	}

	public void ChangeStateMusic(){
		GlobalData.SetMusicActive (toggleMusic.isOn);			
	}
	public void ChangeStateSound(){
		GlobalData.SetSoundActive (toggleSound.isOn);
	}

	public void ChangeLangage(){
		string selectedLanguage = "en";
		if (langage.value == 0)
			selectedLanguage = "fr";
		else if (langage.value == 1)
			selectedLanguage = "en";
		GlobalData.SetCurrentLangage (selectedLanguage);
	}

	public void ChangeJson(){
		GlobalData.GetJsonReader ().GetJsonFile ();
	}

}
