using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaPlatums : MonoBehaviour {

	public GameObject IzmSlaiders;
	public GameObject mainigaisAttels;
	// public GameObject cimds1;
	// public GameObject cimds2;
	// public GameObject cimds3;
	// public GameObject cimds4;

	// Use this for initialization
	public void MainitLielumu(){
		float pasreizejaVertiba = IzmSlaiders.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2 (1f * pasreizejaVertiba,mainigaisAttels.transform.localScale.y);
	}

	// public void MainitDrebjuLielumu(){
	// 	float pasreizejaVertiba = IzmSlaiders.GetComponent<Slider>().value;
	// 	cimds1.transform.localScale = new Vector2 (1f * pasreizejaVertiba,mainigaisAttels.transform.localScale.y);
	// 	cimds2.transform.localScale = new Vector2 (1f * pasreizejaVertiba,mainigaisAttels.transform.localScale.y);
	// 	cimds3.transform.localScale = new Vector2 (1f * pasreizejaVertiba,mainigaisAttels.transform.localScale.y);
	// 	cimds4.transform.localScale = new Vector2 (1f * pasreizejaVertiba,mainigaisAttels.transform.localScale.y);
	// }

}
