using UnityEngine;
using System.Collections;

public class TestSpawnBlock : MonoBehaviour {
	public Vector3 startPos;
	public GameObject [] spawnObjects;
	// Use this for initialization
	void Start () {
		startPos = new Vector3 (-8f, -2f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Alpha1)){
			GameObject spawned = GameObject.Instantiate (spawnObjects[0]);
			spawned.transform.position = startPos;
			startPos.x +=2;
		}
	
	}
}
