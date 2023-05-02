using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cimdi : MonoBehaviour {

	public GameObject CimduBilde;


public void OnToggleClickCimdi()
{
    CimduBilde.SetActive(!CimduBilde.activeSelf);
}

}
