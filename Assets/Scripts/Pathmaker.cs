using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {

	int counter = 0; 
	public Transform floorPrefab; 
	public Transform pathmakerSpherePrefab; 
	public static int noOfTiles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (noOfTiles < 500) {
					float randNum = Random.Range (0f, 1f); 
					if (randNum < .25f) {
						transform.Rotate(0, 90f, 0f); 
					}//second if bracket 
					else if (randNum > .25f && randNum < .5f) {
						transform.Rotate(0, -90f, 0f); 
					} //third if bracket
					else if (randNum > .95f) {
					Instantiate (pathmakerSpherePrefab, transform.position, transform.rotation); 
					}//else bracket 

					Instantiate (floorPrefab, transform.position, transform.rotation); 
					transform.Translate(0, 0, 5f); 
					noOfTiles++; 
					Debug.Log (noOfTiles); 
				} //first if bracket 
				else if(noOfTiles == 500) {

					Destroy (gameObject); 
					Debug.Log ("destroyed!"); 
				}
	
//		Instantiate (floorPrefab, pathmakerSpherePrefab.position, pathmakerSpherePrefab.rotation); 
//		pathmakerSpherePrefab.transform.Translate (0, 0, 5f); 
//		counter++; 

	} //update bracket


} //end whole thing 
