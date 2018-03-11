using UnityEngine;
using System.Collections;

public class TestSpawnBlock : MonoBehaviour {
	public Vector3 startPos;
	public GameObject [] spawnObjects;
	public int obNumber;
	public GameObject hammer;
	Animator anim;
	Vector3 displacement;
	bool spawning = false;
	bool rotating = false;
	int count;
	public int latest = 0;
	public ArrayList currentTerrain = new ArrayList();
	// Use this for initialization
	void Start () {
		anim = hammer.GetComponent<Animator> ();
		//startPos = t.position +displacement ;
		anim.SetBool ("swing", false);
		obNumber = 0;
		count = 0;
		spawning = false;
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
			displacement = 2 * hammer.GetComponent<Transform>().forward + new Vector3 (0f, -2f, 0f);
			startPos = hammer.GetComponent<Transform>().position + displacement;
			spawned.transform.position = startPos;
			spawning = false;
			currentTerrain.Add (spawned);

		}
		if (spawning && rotating) {
			if(count==0){
				anim.SetBool("swing",true);
			}
			if(count < 100){

				count++;
			}
			if(count == 100){
				anim.SetBool("swing",false);
				count++;
			}

			if(count > 100){
				rotating = false;
				count = 0;
			}
		
		}
	
	}
	public void SetOb(int i){
		obNumber = i;
	}

}
