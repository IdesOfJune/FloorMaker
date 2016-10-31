using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Reset : MonoBehaviour {
 
	public GameObject Sphere; 

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R)) {

			Restart (); 


		} //restart if bracket
	
	} //update

	void Restart () {

			Debug.Log("R button pressed!"); 

			SceneManager.LoadScene (0); 

			Sphere.GetComponent<Pathmaker> ().newVariable = 0;  

			
	}

}


