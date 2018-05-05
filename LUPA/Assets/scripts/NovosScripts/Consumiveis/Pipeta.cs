using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeta:Consumiveis {

	private bool contemLiquido;
	private bool estaComPonteira;
	private float capacidade;
	public GameObject ponteira;
	Ponteira objPonteira;
	// Use this for initialization
	void Start () {
		this.objPonteira = ponteira.AddComponent<Ponteira> ();
		contemLiquido = false;
		capacidade = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1) && contemLiquido == false && capacidade >0.2f)
			this.extrairLiquido ();
		else if (Input.GetMouseButtonDown (1) && contemLiquido == true && capacidade < 5.0f)
			this.ejetarLiquido ();
		if (Input.GetMouseButtonDown (2) && estaComPonteira == true && contemLiquido == false)
			this.ejetarPonteira (); 
		else if (Input.GetMouseButtonDown (2) && estaComPonteira == false)
			this.acoplarPonteira ();
	}

	public void equiparṔipeta()
	{
		this.equipar();
	}
	public void desequiparPipeta()
	{
		this.desequipar ();
	}
	void ejetarLiquido ()
	{
		if (objPonteira.RetirarLiquido () == 0)
			return;
		else if (objPonteira.RetirarLiquido () == 1) {
			this.contemLiquido = false;
			return;
		}
		this.capacidade = 5.0f;
	}
	void extrairLiquido ()
	{
		if (objPonteira.ColocarLiquido () == 0)
			return;
		else if (objPonteira.ColocarLiquido () == 1) {
			this.contemLiquido = false;
			return;
		}
		this.capacidade = 0.1f;
	}
	void ejetarPonteira()
	{
		objPonteira.Descartar ();
		estaComPonteira = false;
	}
	void acoplarPonteira()
	{
		estaComPonteira = true;
	}
}

