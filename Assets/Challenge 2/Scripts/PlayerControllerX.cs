using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX1 : MonoBehaviour
{
    public GameObject dogPrefab;
    float timeDelay;

    // Update is called once per frame
    void Start()
    {
        // timeDelay = 2.0f;
    }
    void Update()
    {
        // timeDelay -= Time.deltaTime;
        SpawnRandom();
        // On spacebar press, send dog
    }

    void SpawnRandom(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // timeDelay = 2.0f;
        }
    }
}
