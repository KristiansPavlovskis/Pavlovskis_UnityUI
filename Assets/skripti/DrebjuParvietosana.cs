using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Import to use pointer events interface
using UnityEngine.EventSystems;

// Attach interface
public class DrebjuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformKomponente;
    private Canvas kanva;
    private Transform characterSpawn;
    public GameObject cimdiDrebes;

    void Start()
    {
        // Access image's transform component and fix its coordinates
        transformKomponente = GetComponent<RectTransform>();
        kanva = GetComponentInParent<Canvas>();
        characterSpawn = GameObject.FindGameObjectWithTag("cilveks").transform;
    }

    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Uzspiests uz objekta!");
    }

    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Drag sākums!");
        // Make the clothing item a child of the canvas
       // transform.SetParent(kanva.transform);
    }

    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Objekts tiek kustināts!");
        transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
{
    Debug.Log("Drag Pabeigts!");

   // if (!EventSystem.current.IsPointerOverGameObject())
    //{
        if (!characterSpawn)
        {
            
            transform.SetParent(cimdiDrebes.transform);
          
        }
        else
        {
         transform.SetParent(characterSpawn);     
        }
    //}
}

}
