using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaGarums : MonoBehaviour {
	public GameObject IzmSlaiders;
	public GameObject mainigaisAttels;
	// public GameObject cimds1;
	// public GameObject cimds2;
	// public GameObject cimds3;
	// public GameObject cimds4;
	// public GameObject bikses1;
	// public GameObject bikses2;
	// public GameObject bikses3;
	// public GameObject bikses4;
	// public GameObject mati1;
	// public GameObject mati2;
	// public GameObject mati3;
	// public GameObject mati4;
	// public GameObject krekls1;
	// public GameObject krekls2;
	// public GameObject krekls3;
	// public GameObject krekls4;
	// public GameObject kurpes1;
	// public GameObject kurpes2;
	// public GameObject kurpes3;
	// public GameObject kurpes4;

	// Use this for initialization
	public void MainitLielumu(){
		float pasreizejaVertiba = IzmSlaiders.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2 (mainigaisAttels.transform.localScale.x, 1f * pasreizejaVertiba);
		// cimds1.transform.localScale = new Vector2 (cimds1.transform.localScale.x, 1f * pasreizejaVertiba);
		// cimds2.transform.localScale = new Vector2 (cimds2.transform.localScale.x, 1f * pasreizejaVertiba);
		// cimds3.transform.localScale = new Vector2 (cimds3.transform.localScale.x, 1f * pasreizejaVertiba);
		// cimds4.transform.localScale = new Vector2 (cimds4.transform.localScale.x, 1f * pasreizejaVertiba);
		// bikses1.transform.localScale = new Vector2 (bikses1.transform.localScale.x, 1f * pasreizejaVertiba);
		// bikses2.transform.localScale = new Vector2 (bikses2.transform.localScale.x, 1f * pasreizejaVertiba);
		// bikses3.transform.localScale = new Vector2 (bikses3.transform.localScale.x, 1f * pasreizejaVertiba);
		// bikses4.transform.localScale = new Vector2 (bikses4.transform.localScale.x, 1f * pasreizejaVertiba);
		// mati1.transform.localScale = new Vector2 (mati1.transform.localScale.x, 1f * pasreizejaVertiba);
		// mati2.transform.localScale = new Vector2 (mati2.transform.localScale.x, 1f * pasreizejaVertiba);
		// mati3.transform.localScale = new Vector2 (mati3.transform.localScale.x, 1f * pasreizejaVertiba);
		// mati4.transform.localScale = new Vector2 (mati4.transform.localScale.x, 1f * pasreizejaVertiba);
		// krekls1.transform.localScale = new Vector2 (krekls1.transform.localScale.x, 1f * pasreizejaVertiba);
		// krekls2.transform.localScale = new Vector2 (krekls2.transform.localScale.x, 1f * pasreizejaVertiba);
		// krekls3.transform.localScale = new Vector2 (krekls3.transform.localScale.x, 1f * pasreizejaVertiba);
		// krekls4.transform.localScale = new Vector2 (krekls4.transform.localScale.x, 1f * pasreizejaVertiba);
		// kurpes1.transform.localScale = new Vector2 (kurpes1.transform.localScale.x, 1f * pasreizejaVertiba);
		// kurpes2.transform.localScale = new Vector2 (kurpes2.transform.localScale.x, 1f * pasreizejaVertiba);
		// kurpes3.transform.localScale = new Vector2 (kurpes3.transform.localScale.x, 1f * pasreizejaVertiba);
		// kurpes4.transform.localScale = new Vector2 (kurpes4.transform.localScale.x, 1f * pasreizejaVertiba);
	}
}
