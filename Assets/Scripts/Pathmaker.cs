using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class Pathmaker : MonoBehaviour {


	//variables regarding the floormaker

	int counter; 
	int localCounter; 
	public Transform floorPrefab; 
	public Transform pathmakerSpherePrefab; 
	public static int noOfTiles;
	public float minRange; //default .25
	public float maxRange; //default .50
	float spawnChance; //default .95 
	public GameObject HitR; 
	public bool canPlayAgain; 

	//variables regarding reset
	public int newVariable; 

	//variables regarding arrays 

	public GameObject [] pickFromTiles; 
	int index; 

	// Use this for initialization
	void Start () {

		HitR.SetActive (false); 

		index = Random.Range (0, pickFromTiles.Length); 

		localCounter = Random.Range (0, 85); 
		//Debug.Log ("my localCounter is" + localCounter); //different lifetimes for each Pathmaker

		spawnChance = Random.Range (.90f, .97f); 
		//Debug.Log ("my spawnChance is" + spawnChance); //different spawn chances for each Pathmaker to create another one 

		noOfTiles = newVariable; 


	}
	
	// Update is called once per frame
	void Update () {

		newVariable = noOfTiles; 

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

					spawnPickedTile (); 

					
					//Debug.Log (noOfTiles); //tells number of tiles 

				} //first if bracket 

			else if(counter > localCounter || noOfTiles == 550) {

			gameObject.SetActive(false); 
			Debug.Log ("destroyed!"); 

			HitR.SetActive(true); 
			//Debug.Log (noOfTiles); 
				} //end else if bracket
			


	} //update bracket

	void spawnPickedTile () { //spawn the tile 

		Instantiate (pickFromTiles[index], transform.position, transform.rotation); 
		transform.Translate(0, 0, 5f); 
		noOfTiles++; 
		counter++; 

	} //spawnPickedTile bracket 

	void ToggleCanPlay () {

	

	}


} //end whole thing 


