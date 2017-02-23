using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour {

	private static string currentLangage;
	private static bool firstCheck = true;
	private static bool musicActive,soundActive;
	private static JsonReader jsonReader;


	public static void FirstCheck(){
	}
		
	public static void SetJsonReader(JsonReader _jsonReader){
		jsonReader = _jsonReader;
	}

	public static JsonReader GetJsonReader(){
		return jsonReader;
	}

	public static void SetCurrentLangage(string langage){
		currentLangage = langage;
	}

	public static void SetFirstCheck(bool state){
		firstCheck = state;
	}

	public static void SetMusicActive(bool state){
		musicActive = state;
	}

	public static void SetSoundActive(bool state){
		soundActive = state;
	}

	public static bool IsMusicActive(){
		return musicActive;
	}
		
	public static bool IsSoundcActive(){
		return soundActive;
	}

	public static bool IsFirstCheck(){
		return firstCheck;
	}

	public static string GetCurrentLangage(){
		return currentLangage;
	}

	private static void CheckSystemLangage(){
		switch (Application.systemLanguage) {
		case SystemLanguage.French:
			SetCurrentLangage("fr");
			break;
		case SystemLanguage.English:
			SetCurrentLangage("en");
			break;
		default :
			SetCurrentLangage("en");
			break;
		}
	}

	private static void CheckSettingLangage(){
	}

	public static void SelectLangage(){
		if (IsFirstCheck ())
			CheckSystemLangage ();
		else
			CheckSettingLangage ();
	}
}
