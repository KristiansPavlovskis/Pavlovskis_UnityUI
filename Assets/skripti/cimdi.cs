using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cimdi : MonoBehaviour {

	public GameObject CimduBilde;

public void OnToggleClick()
{
    CimduBilde.SetActive(!CimduBilde.activeSelf);
}
}
