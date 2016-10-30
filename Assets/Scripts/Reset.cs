using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Reset : MonoBehaviour {

	public static int noOfTiles; 

	// Use this for initialization
	void Start () {

		Debug.Log ("test"); 
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R)) {

			noOfTiles = 0; 

			Debug.Log("R button pressed!"); 

			SceneManager.LoadScene (0); 


		} //restart if bracket
	
	} //update
}
