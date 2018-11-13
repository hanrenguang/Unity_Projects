using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
  private bool isDead = false;
  private Rigidbody2D rg2d;
	private Animator anim;

	public float upForce = 200f;

	// Use this for initialization
	void Start () {
    rg2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false) {
			if (Input.GetMouseButtonDown(0)) {
				rg2d.velocity = Vector2.up;
				rg2d.AddForce(new Vector2(0, upForce));
				anim.SetTrigger("flap");
			}
		}
	}

	void OnCollisionEnter2D (Collision2D other) {
		rg2d.velocity = Vector2.zero;
		isDead = true;
		anim.SetTrigger("die");
		GameControl.instance.BirdDie();
	}
}
