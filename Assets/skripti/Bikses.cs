using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bikses : MonoBehaviour {

	// Use this for initialization
	public GameObject BiksesBilde;


	public void OnToggleClickBikses()
	{
		BiksesBilde.SetActive(!BiksesBilde.activeSelf);
	}
}
