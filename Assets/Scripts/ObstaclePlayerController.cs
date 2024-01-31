using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private Vector3 offset = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
