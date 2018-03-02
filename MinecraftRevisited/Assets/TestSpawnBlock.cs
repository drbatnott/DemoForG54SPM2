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
			displacement = 2 * t.forward + new Vector3 (0f, -2f, 0f);
			startPos = t.position + displacement;
			spawned.transform.position = startPos;
			spawning = false;


		}
		if (spawning && rotating) {
			t.RotateAround (Vector3.zero,Vector3.left,10f);
			count++;
			if(count == 10){
				rotating = false;
				t.RotateAround (Vector3.zero,Vector3.left,-100f);
			}
		}
	
	}
	public void SetOb(int i){
		obNumber = i;
	}
}
