using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krekli : MonoBehaviour {

	// Use this for initialization
	public GameObject KrekliBilde;


	public void OnToggleClickKrekli()
	{
		KrekliBilde.SetActive(!KrekliBilde.activeSelf);
	}
}
