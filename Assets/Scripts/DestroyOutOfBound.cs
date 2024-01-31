using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    float topBounds = 50.0f;
    float lowBounds = -20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds){
            Destroy(gameObject);
        }
        else if(transform.position.z < lowBounds){
            Debug.Log("Game Over!!");
            Destroy(gameObject);
        }
    }
}
