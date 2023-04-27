using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarduGlabasana : MonoBehaviour {

	private string teksts;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;


	public void UzglabatTekstu(){
		
		teksts = ievadesLauks.GetComponent<InputField>().text;
		tekstaAttelosana.GetComponent<Text>().text = teksts;
	}
}
