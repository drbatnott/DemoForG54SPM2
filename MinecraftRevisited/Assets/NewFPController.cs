using UnityEngine;
using System.Collections;

public class NewFPController : MonoBehaviour {
	public float speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float v = Mathf.Abs(Input.GetAxis ("Vertical"));
		transform.position += transform.forward* speed * v * Time.deltaTime;
		float r = Input.GetAxis ("Horizontal");
		transform.Rotate (Vector3.up, r);
	}
}
