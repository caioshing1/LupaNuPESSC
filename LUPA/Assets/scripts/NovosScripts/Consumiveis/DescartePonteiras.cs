using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescartePonteiras : Consumiveis {
	private int conteudo;
	private bool precisaDescartar;
	private int capacidade;
	// Use this for initialization
	void Start () {
		this.conteudo = 0;
		this.capacidade = 10;
		this.precisaDescartar = false;
	}

	public void limparDescarte()
	{
		this.conteudo = 0;
		precisaDescartar = false;
	}
	public int acrescentarDescarte()
	{
		if (this.conteudo < this.capacidade) {
			this.conteudo++;
			return 1;
		} else
			return 0; 
	}
	public int chekarLixo ()
	{
		return this.conteudo;
	}
}
