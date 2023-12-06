using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectModelSwap : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * 1f);

        RaycastHit hit;
        //raycast parameters (origin, direction, distance)
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1f))
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
