using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour {


	private static bool firstCheck = true;
	public static string currentLangage;
	public static JsonReader jsonReader;

	// Use this for initialization
	void Start () {
		
	}
	void Awake(){
		if (firstCheck) {
			firstCheck = false;
			CheckLangage ();
		} else
			SelectLangage ();
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheckLangage(){
		switch (Application.systemLanguage) {
		case SystemLanguage.French:
			currentLangage = "fr";
			break;
		case SystemLanguage.English:
			currentLangage = "en";
			break;
		default :
			currentLangage = "en";
			break;
		}
	}

		private void SelectLangage(){
	}

}
