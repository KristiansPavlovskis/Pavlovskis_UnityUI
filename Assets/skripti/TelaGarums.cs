using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaGarums : MonoBehaviour {
	public GameObject IzmSlaiders;
	public GameObject mainigaisAttels;

	// Use this for initialization
	public void MainitLielumu(){
		float pasreizejaVertiba = IzmSlaiders.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2 (mainigaisAttels.transform.localScale.x, 1f * pasreizejaVertiba);
	}
}
