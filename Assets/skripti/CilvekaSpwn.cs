using UnityEngine;
using System.Collections;

public class CilvekaSpwn : MonoBehaviour
{
    public GameObject maleCharacterPrefab;
    public GameObject femaleCharacterPrefab;
    public Transform characterSpawn;
	//Collider = get
    float minX, maxX;

    void Start()
    {
        characterSpawn = GetComponent<Transform>();

        if (cilvekaIzvelesanas.izveletaisCilveks == "Female")
        {
        
            minX = characterSpawn.position.x - 0;        
            maxX = characterSpawn.position.x + 0;
            var randomX = Random.Range(minX, maxX);
            var position = new Vector2(randomX, characterSpawn.position.y);
            GameObject femaleCharacter = Instantiate(femaleCharacterPrefab, position, Quaternion.identity, characterSpawn);

			var bCol = femaleCharacter.AddComponent<BoxCollider>();
			femaleCharacter.gameObject.tag = "cilveks";

            femaleCharacter.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            
        }
        else 
        {
            minX = characterSpawn.position.x - 0;        
            maxX = characterSpawn.position.x + 0;
            var randomX = Random.Range(minX, maxX);
            var position = new Vector2(randomX, characterSpawn.position.y);
            GameObject maleCharacter = Instantiate(maleCharacterPrefab, position, Quaternion.identity, characterSpawn);

			var bCol = maleCharacter.AddComponent<BoxCollider>();
			maleCharacter.gameObject.tag = "cilveks";

            maleCharacter.transform.localScale = new Vector3(0.035f, 0.05f, 0.05f);
         
        }
    }
}
