using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidraria : MonoBehaviour {
	public int conteudo;
	public int capacidade;
	public bool quebrado;
	// Use this for initialization
	void Start () {
		conteudo = 2;
		capacidade = 3;
		quebrado = false;
	}
	public int aumentarVolume(int Conteudo)
	{
		if (Conteudo + 1 <= this.capacidade) {
			Conteudo++;
			return 1;
		} else
			return 0;
	}

	public int diminuirVolume(int Conteudo)
	{
		if (Conteudo -1>=0) {
			Conteudo--;
			return 1;
		} else
			return 0;
	}
	public void quebrar()
	{
		Destroy (this.gameObject);
	}
}
