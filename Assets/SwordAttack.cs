using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwordAttack : MonoBehaviour
{

    public GameObject basicAttackDreamer; 
    public float destroyDelay = 0.5f;  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawnHitbox = Instantiate(basicAttackDreamer, transform.position, transform.rotation);

            Destroy(spawnHitbox, destroyDelay);
        }
    }
}