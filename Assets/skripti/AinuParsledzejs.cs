﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	// Use this for initialization
	public void UzSakumu(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
	public void CilvekaIzvele(){
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}
	public void UzViritiesDrebem(){
		
			SceneManager.LoadScene (2, LoadSceneMode.Single);

	}
	public void UzSievietesDrebem(){
		if (cilvekaIzvelesanas.izveletaisCilveks == "Female") {
			SceneManager.LoadScene (3, LoadSceneMode.Single);
		}
	}
	//Metode , kura aizver programmu, ja tā ir izveidota kā .exe
	public void Apturet(){
		Application.Quit();
	}

}
