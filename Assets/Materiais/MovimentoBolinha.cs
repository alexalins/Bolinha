using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentoBolinha : MonoBehaviour {

	private Rigidbody rb;
	public float velocidade;

	public GameObject particulaItem;

	public Text textoPontos;
	public Text textoFinal;

	private int pontos;

	void Start () {
		//rb da bolinha
		rb = GetComponent<Rigidbody>();

		//texto
		textoFinal.text = "";
		textoPontos.text = textoPontos.text + pontos.ToString();
		
	}
	
	void FixedUpdate () {
		//andando nas setinhas
		Vector3 move = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		//forca pra andar
		rb.AddForce (move * velocidade);
	}

	void OnTriggerEnter(Collider outro){
		//batendo no objeto
		if (outro.gameObject.CompareTag ("Item")) {
			//particula
			Instantiate (particulaItem, outro.gameObject.transform.position, Quaternion.identity);
			//destroi objeto
			Destroy(outro.gameObject);
			//pontos
			marcaPontos ();

		}
	}

	void marcaPontos(){
		pontos++;
		textoPontos.text = "Score: "+ pontos.ToString();

		if (pontos == 2) {

			textoFinal.text = "YOU WIN!";
		}
	}
}
