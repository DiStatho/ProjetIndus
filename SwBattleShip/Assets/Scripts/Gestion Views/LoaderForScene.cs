using UnityEngine.SceneManagement;
using UnityEngine;

public class LoaderForScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenScene(string nameScene){
		SceneManager.LoadScene (nameScene);
	}

}
