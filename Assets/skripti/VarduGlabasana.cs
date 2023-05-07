using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarduGlabasana : MonoBehaviour {

		public string vards;
	public string vecums;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	//public string vardGlabasana;

	public GameObject ievadesLauks1;
	//public GameObject tekstaAttelosana1;



	public void UzglabatTekstu(){
		
		vards = ievadesLauks.GetComponent<InputField>().text;
		

		vecums = ievadesLauks1.GetComponent<InputField>().text;
		
		tekstaAttelosana.GetComponent<Text>().text = "Tavu cilvēku sauks "+vards+" kurš ir "+vecums+" gadus vecs!";
		//tekstaAttelosana1.GetComponent<Text>().text = vecums;
		// vardGlabasana = Vards+" ir "+vecums+" gadus vecs";
	}

	
}
