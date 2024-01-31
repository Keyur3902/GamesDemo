using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    float horizontalInput;
    float speed = 30.0f;
    float range = 20.0f;
    public GameObject projectileFood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectileFood, transform.position, projectileFood.transform.rotation);
        }

        if(transform.position.x < -range){
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        if(transform.position.x > range){
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
