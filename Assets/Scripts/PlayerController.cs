using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float verticalInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            transform.Translate(0, 0, 1);

            // Move the player forward/backward based on vertical touch movement
            // float verticalInput = 100 * touch.deltaPosition.y / Screen.height;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

            // Rotate the player based on horizontal touch movement
            if (touch.phase == TouchPhase.Moved)
            {
                float horizontalInput = touch.deltaPosition.x / Screen.width;
                transform.Rotate(Vector3.up, turnSpeed * horizontalInput);
            }
        }

        else
        {
            // transform.Translate(0, 0, 1);
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
            // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
