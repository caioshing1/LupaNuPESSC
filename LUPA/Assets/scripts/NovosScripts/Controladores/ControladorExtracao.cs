using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorExtracao : MonoBehaviour {
	public GameObject pipeta;
	public GameObject amostra;
	public Ponteira scrPonteira;
	public Amostra scrAmostra;
	// Use this for initialization
	void Start () {
		scrAmostra = amostra.AddComponent<Amostra> ();
		scrPonteira = pipeta.AddComponent<Ponteira> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (scrAmostra.gameObject.transform.position, scrPonteira.gameObject.transform.position) <= 3) {
		
		}
	}

}
