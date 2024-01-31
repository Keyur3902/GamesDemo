using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanePropeller : MonoBehaviour
{

    public float rotationSpeed = 100.0f;
    public GameObject player;
    Vector3 offset = new Vector3(0, 0, 100);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.Rotate(offset * rotationSpeed * Time.deltaTime);
    }
}
