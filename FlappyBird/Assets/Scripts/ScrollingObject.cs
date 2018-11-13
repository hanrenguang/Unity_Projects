using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	private Rigidbody2D rg2d;

	// Use this for initialization
	void Start () {
		rg2d = GetComponent<Rigidbody2D> ();
		rg2d.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.instance.gameOver == true) {
			rg2d.velocity = Vector2.zero;
		}
	}
}
