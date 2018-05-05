using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amostra : Vidraria {
	public GameObject[] textura;
	// Use this for initialization
	void Start () {
		this.conteudo = 2;
		this.capacidade = 3;
	}
	
	void extrairLiquido()
	{
		this.textura [this.conteudo].SetActive (false);
		if (this.diminuirVolume(this.conteudo) == 0) {
			Debug.Log ("Nao Foi Permitido");
		}
		this.textura [this.conteudo].SetActive (true);
	}
	void ejetarLiquido()
	{
		if(this.aumentarVolume(this.conteudo) == 1)
		{
			this.textura[this.conteudo].SetActive(true);
		}
	}
}
