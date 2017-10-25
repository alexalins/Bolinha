using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBolinha : MonoBehaviour {

	private Rigidbody rb;
	public float velocidade;

	void Start () {

		rb = GetComponent<Rigidbody>();
		
	}
	
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		rb.AddForce (move * velocidade);
	}
}
