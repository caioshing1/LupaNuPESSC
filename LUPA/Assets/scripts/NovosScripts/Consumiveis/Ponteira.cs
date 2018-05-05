using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponteira:Consumiveis {
	public Texture[] textura;
	private bool estaAtiva;
	private bool foiUtilizada;
	// Use this for initialization
	void Start () {
		this.estaAtiva = true;
		this.textura = new Texture[1];
		this.foiUtilizada = false;
		textura [0] = this.GetComponent<MeshRenderer> ().material.mainTexture;
	}

	public int ColocarLiquido()
	{
		if (this.foiUtilizada == false) {
			this.GetComponent<MeshRenderer> ().material.mainTexture = textura [1];
			this.foiUtilizada = true;
			return 1;
		} else
			return 0;
	}
	public int RetirarLiquido()
	{
		if (this.foiUtilizada == false) {
			this.GetComponent<MeshRenderer> ().material.mainTexture = textura [0];
			this.foiUtilizada = true;
			return 1;
		} else
			return 0;
	}
	public void Descartar ()
	{
		this.desequipar ();
		this.estaAtiva = false;
	}
}
