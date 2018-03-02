using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnCollisionEnter(Collision col){
		if (col.gameObject.name.Contains ("Cube"))
			Destroy (col.gameObject);
		
	}
}
