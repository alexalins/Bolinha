using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBolinha : MonoBehaviour {

	private Rigidbody rb;
	public float velocidade;

	public GameObject particulaItem;

	void Start () {

		rb = GetComponent<Rigidbody>();
		
	}
	
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		rb.AddForce (move * velocidade);
	}

	void OnTriggerEnter(Collider outro){
		if (outro.gameObject.CompareTag ("Item")) {
			Instantiate (particulaItem, outro.gameObject.transform.position, Quaternion.identity);
			Destroy(outro.gameObject);
		}
	}
}
