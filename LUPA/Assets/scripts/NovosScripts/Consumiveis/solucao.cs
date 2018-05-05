using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solucao : Consumiveis {

	private int codigoDaSolucao;
	private int volumeDisponivel;
	private int capacidade;
	// Use this for initialization
	void Start () {
		this.volumeDisponivel = 5;
		this.capacidade = 5;
	}

	public int aumentarSolucao ()
	{
		if (this.volumeDisponivel < this.capacidade) {
			this.volumeDisponivel++;
			return this.volumeDisponivel;
		}
		return capacidade;
	}
	public int diminuirSolucao()
	{
		if (this.volumeDisponivel > 0) {
			this.volumeDisponivel--;
			return this.volumeDisponivel;
		}
		return 0;
	}
	public void inicializarCodigo (int codigoAtribuido)
	{
		this.codigoDaSolucao = codigoAtribuido;
	}
}
