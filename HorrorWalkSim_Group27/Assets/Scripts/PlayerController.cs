using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;

    void Update()
    {

        RotateToCamera();

        //Side to side movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
    }

    public void RotateToCamera()
    {
        GameObject camera = Camera.main.gameObject;

        Vector3 newRotation = camera.transform.rotation.eulerAngles;

        newRotation.x = transform.rotation.x;
        newRotation.z = transform.rotation.z;
        transform.rotation = Quaternion.Euler(newRotation);
    }


}
