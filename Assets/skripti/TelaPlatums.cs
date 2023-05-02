using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaPlatums : MonoBehaviour {

	public GameObject IzmSlaiders;
	public GameObject mainigaisAttels;

	// Use this for initialization
	public void MainitLielumu(){
		float pasreizejaVertiba = IzmSlaiders.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2 (1f * pasreizejaVertiba,mainigaisAttels.transform.localScale.y);
	}
}
