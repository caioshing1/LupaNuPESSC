using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInteacoesPipeta : MonoBehaviour {
	public GameObject pipetamesa;
	public GameObject pipetaEquipada;
	private bool equipou;
	// Use this for initialization
	void Start () {
		equipou = false;
		pipetaEquipada.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (Camera.main.transform.position, pipetamesa.transform.position) <= 3 && Input.GetKeyUp(KeyCode.E))
		{
			if(this.equipou == false)
			{
				pipetamesa.SetActive(false);
				pipetaEquipada.SetActive(true);
				this.equipou = true;
			}

			else
			{
				pipetamesa.SetActive(true);
				pipetaEquipada.SetActive(false);
				this.equipou = false;
			}

		}
	}
}
