using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour {

	public Transform Caminho;
	public Vector3 distancia;
	public float distanciaM;
	private Quaternion rotacao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distancia = transform.position - Caminho.position;
		distanciaM = Vector3.Distance (transform.position,Caminho.position);

		if (distanciaM < 3) {
			if (Caminho.childCount > 0){
				Caminho = Caminho.GetChild (0);
			}
		}

		rotacao = Quaternion.LookRotation (distancia);
		Quaternion novaRotation = Quaternion.Euler(transform.rotation.x, rotacao.eulerAngles.y - 180, transform.rotation.z);
		transform.rotation = novaRotation;
	//	transform.rotation.eulerAngles.y = rotacao.eulerAngles.y;
		transform.Translate (0,0,10*Time.deltaTime);
	}
}
