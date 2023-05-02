using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mati : MonoBehaviour {

	// Use this for initialization
	public GameObject MatuBilde;


	public void OnToggleClickMati()
	{
		MatuBilde.SetActive(!MatuBilde.activeSelf);
	}
}
