using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumiveis : MonoBehaviour {

	private bool emUso;
	void Start()
	{
		this.emUso = false;
	}
	public void equipar()
	{
		this.gameObject.SetActive (true);
		this.emUso = true;
	}
	public void desequipar()
	{
		this.gameObject.SetActive (false);
		this.emUso =false;
	}


}
