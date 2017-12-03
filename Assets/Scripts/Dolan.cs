using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolan : MonoBehaviour {

	public float upForce = 200f;
<<<<<<< HEAD
	public AudioSource[] sound;
	public AudioSource flapSound;
	public AudioSource hit;
=======
>>>>>>> origin/master

	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anime;

	void Start () {
		rb2d  = GetComponent<Rigidbody2D> ();
		anime = GetComponent<Animator> ();
<<<<<<< HEAD
		sound = GetComponents<AudioSource> ();
		flapSound = sound[0];
		hit = sound[1];
=======
>>>>>>> origin/master
	}

	void Update () {
		if (isDead == false) {
			if (Input.GetMouseButtonDown(0)) {
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce (new Vector2(0, upForce));
				anime.SetTrigger ("Flap");
<<<<<<< HEAD
				flapSound.Play ();
			}
		}
		if (Input.GetKeyDown (KeyCode.Escape)) { 
			Application.Quit (); 
		}
	}

	void OnCollisionEnter2D () {
		rb2d.velocity = Vector2.zero;
		isDead = true;
		anime.SetTrigger ("Die");
		hit.Play ();
		GameControl.instance.DolanDied();
=======

			}
		}
	}

	void OnCollisionEnter2D () {
		isDead = true;
		anime.SetTrigger ("Die");
>>>>>>> origin/master
	}
}
