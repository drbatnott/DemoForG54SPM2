using UnityEngine;
using System.Collections;

public class TestSpawnBlock : MonoBehaviour {
	public Vector3 startPos;
	public GameObject [] spawnObjects;
	public int obNumber;
	public GameObject hammer;
	Transform t;
	Vector3 displacement;
	bool spawning = false;
	bool rotating = false;
	int count;
	public int latest = 0;
	public ArrayList currentTerrain = new ArrayList();
	// Use this for initialization
	void Start () {
		t = hammer.GetComponent<Transform> ();
		//startPos = t.position +displacement ;

		obNumber = 0;
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Space) && !spawning){
			spawning =true;
			rotating = true;
			count = 0;
		}
		if (!rotating && spawning){
			GameObject spawned = GameObject.Instantiate (spawnObjects[obNumber]);
			latest = currentTerrain.Count;
			latest++;
			spawned.name = "Cube_" + latest.ToString ();
			displacement = 2 * t.forward + new Vector3 (0f, -2f, 0f);
			startPos = t.position + displacement;
			spawned.transform.position = startPos;
			spawning = false;
			currentTerrain.Add (spawned);

		}
		if (spawning && rotating) {
			if(count < 10){
				t.RotateAround (Vector3.zero,Vector3.left,10f);
				count++;
			}
			if(count == 10){

			}

			if(count < 20){
				count++;
				t.RotateAround (Vector3.zero,Vector3.left,-100f);
			}

			else{
				rotating = false;
			}
		
		}
	
	}
	public void SetOb(int i){
		obNumber = i;
	}

}
