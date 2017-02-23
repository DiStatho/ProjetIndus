using UnityEngine.UI;
using UnityEngine;

public class Setting : MonoBehaviour {

	public Toggle toggleSound, toggleMusic;
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
		
	}

	

}
