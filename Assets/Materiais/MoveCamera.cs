using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public GameObject objetoBolinha;
	private Vector3  posicaoInicial;

	void Start () {
		//posicao inicial da camera
		posicaoInicial = transform.position - objetoBolinha.transform.position;
		
	}

	void LateUpdate () {
		//posicao da camera 
		transform.position = objetoBolinha.transform.position + posicaoInicial;
	}
}
