using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Pathmaker : MonoBehaviour {

	int counter; 
	int localCounter; 
	public Transform floorPrefab; 
	public Transform pathmakerSpherePrefab; 
	public static int noOfTiles;
	public float minRange; //default .25
	public float maxRange; //default .50
	float spawnChance; //default .95 

	// Use this for initialization
	void Start () {

		localCounter = Random.Range (0, 85); 
		Debug.Log ("my localCounter is" + localCounter); //different lifetimes for each Pathmaker

		spawnChance = Random.Range (.90f, .97f); 
		Debug.Log ("my spawnChance is" + spawnChance); //different spawn chances for each Pathmaker to create another one 

	}
	
	// Update is called once per frame
	void Update () {


		if (noOfTiles < 550) {
				float randNum = Random.Range (0f, 1f); 
			if (randNum < minRange) { //if randNum is less than this number, turn right 
						transform.Rotate(0, 90f, 0f); 
					}//second if bracket 
			else if (randNum > minRange && randNum < maxRange) { //if randNum is less than this number (default > .25f && < .5, turn left 
						transform.Rotate(0, -90f, 0f); 
					} //third if bracket
			else if (randNum > spawnChance) { //spawn another PathMaker 
					Instantiate (pathmakerSpherePrefab, transform.position, transform.rotation); 
					}//else bracket 

					Instantiate (floorPrefab, transform.position, transform.rotation); 
					transform.Translate(0, 0, 5f); 
					noOfTiles++; 
					counter++; 

					//Debug.Log (noOfTiles); //tells number of tiles 

				} //first if bracket 
			else if(counter > localCounter || noOfTiles == 550) {

			Destroy (gameObject); 
			Debug.Log ("destroyed!"); 
			Debug.Log (noOfTiles); 
				} //end else if bracket

	
	


	} //update bracket


} //end whole thing 

//		Instantiate (floorPrefab, pathmakerSpherePrefab.position, pathmakerSpherePrefab.rotation); 
//		pathmakerSpherePrefab.transform.Translate (0, 0, 5f); 
//		counter++; 
