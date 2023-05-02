using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kurpes : MonoBehaviour {

	public GameObject KurpjuBilde;


	public void OnToggleClickKurpes()
	{
		KurpjuBilde.SetActive(!KurpjuBilde.activeSelf);
	}
}
