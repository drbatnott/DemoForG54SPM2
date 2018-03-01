using UnityEngine;
using System.Collections;

public class TestRandomTerrain : MonoBehaviour {

	// Use this for initialization
	public GameObject [] prefabBlocks; 
	public ArrayList blocksArray;
	public int blockDimension = 2;
	void Start () {
		blocksArray = new ArrayList ();
		Vector3 start = new Vector3 (-10f, 0f, -10f);
		Vector3 rowStart = start;
		for (int i = 0; i<10; i++) { // rows of terrain
			for (int j = 0; j < 10; j++) {//columns
				int type = Random.Range (0, 5);
				if (type != 0) {
					GameObject spawn = Instantiate (prefabBlocks [type - 1]);
					spawn.transform.position = new Vector3 (rowStart.x + j * blockDimension, rowStart.y, rowStart.z);
					blocksArray.Add (spawn);
				}
			}
			rowStart += new Vector3(0f,0f,blockDimension);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
