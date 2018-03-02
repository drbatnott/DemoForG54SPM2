using UnityEngine;
using System.Collections;

public class SetCursor : MonoBehaviour {
	public Texture2D positionCursor;
	// Use this for initialization
	void Start () {
		Cursor.SetCursor (positionCursor, Vector2.zero, CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
