using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

        Debug.DrawLine(transform.position, transform.position + transform.forward * 3f);

        RaycastHit hit;
        //raycast parameters (origin, direction, distance)
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            if (hit.collider.GetComponent<ModelSwap>())
            {
                //Debug.Log("hit modelswap");

                //checks for both hitting e plus if the raycast is colliding with box collider
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<ModelSwap>().SwapModel();
                }
            }
        }
    }
}
