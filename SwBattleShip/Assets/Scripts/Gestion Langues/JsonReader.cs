using SimpleJSON;
using UnityEngine;

public class JsonReader : MonoBehaviour {

	private JSONNode _json;
	private Object _jsonFile;

	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		if (GlobalData.IsFirstCheck ()) {
			GlobalData.SetJsonReader (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string ReadValue(string key){
		if (_json == null)
			GetJsonFile ();
		if (_json == null || _json [key] == null)
			return "Unknow";
		return _json[key].Value;
	}

	private void GetJsonFile(){
		string path = string.Format ("strings_{0}", GlobalData.GetCurrentLangage());
		print (path);
		_jsonFile = Resources.Load (path, typeof(object));
		_json = JSON.Parse (_jsonFile.ToString ());
	}
}
