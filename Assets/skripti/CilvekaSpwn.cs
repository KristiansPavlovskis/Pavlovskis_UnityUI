using UnityEngine;
using System.Collections;

public class CilvekaSpwn : MonoBehaviour
{
    public GameObject maleCharacterPrefab;
    public GameObject femaleCharacterPrefab;
    public Transform characterSpawn;

    // Collider = get
    float minX, maxX;

    void Start()
    {
        characterSpawn = GetComponent<Transform>();

        if (cilvekaIzvelesanas.izveletaisCilveks == "Female")
        {
            SpawnCharacter(femaleCharacterPrefab, 0.05f);
        }
        else 
        {
            SpawnCharacter(maleCharacterPrefab, 0.035f);
        }
    }

    private void SpawnCharacter(GameObject characterPrefab, float scale)
    {
        minX = characterSpawn.position.x - 0;        
        maxX = characterSpawn.position.x + 0;
        var randomX = Random.Range(minX, maxX);
        var position = new Vector2(randomX, characterSpawn.position.y);



        GameObject character = Instantiate(characterPrefab, position, Quaternion.identity, characterSpawn);
        var bCol = character.AddComponent<BoxCollider>();
        character.gameObject.tag = "cilveks";
        character.transform.localScale = new Vector3(scale, 0.05f, 0.05f);
    }
}
