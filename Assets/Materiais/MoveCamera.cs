using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public GameObject objetoBolinha;
	private Vector3  posicaoInicial;

	void Start () {
		
		posicaoInicial = transform.position;
		
	}

	void Update () {
		transform.position = objetoBolinha.transform.position + posicaoInicial;
	}
}
