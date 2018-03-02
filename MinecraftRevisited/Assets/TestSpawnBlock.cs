using UnityEngine;
using System.Collections;

public class TestSpawnBlock : MonoBehaviour {
	public Vector3 startPos;
	public GameObject [] spawnObjects;
	public int obNumber;
	// Use this for initialization
	void Start () {
		startPos = new Vector3 (-8f, -2f, 0f);
		obNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)){
			GameObject spawned = GameObject.Instantiate (spawnObjects[obNumber]);
			spawned.transform.position = startPos;
			startPos.x +=2;
		}
	
	}
	public void SetOb(int i){
		obNumber = i;
	}
}
