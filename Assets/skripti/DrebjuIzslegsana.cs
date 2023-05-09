using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrebjuIzslegsana : MonoBehaviour {

	public GameObject CimduBilde;
    public GameObject BiksesBilde;
    public GameObject KurpesBilde;
    public GameObject KrekluBilde;
    public GameObject MatuBilde;


public void Cimdi()
{
    CimduBilde.SetActive(!CimduBilde.activeSelf);
}
public void Bikses()
{
    BiksesBilde.SetActive(!BiksesBilde.activeSelf);
}
public void Kurpes()
{
    KurpesBilde.SetActive(!KurpesBilde.activeSelf);
}
public void Krekli()
{
    KrekluBilde.SetActive(!KrekluBilde.activeSelf);
}
public void Mati()
{
    MatuBilde.SetActive(!MatuBilde.activeSelf);
}

}
