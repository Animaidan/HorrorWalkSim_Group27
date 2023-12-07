using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectModelSwap : MonoBehaviour
{
    public static int ObjectsCleaned;

    //static makes the variable available anywhere
    //static means there is only ONE of the variable in the entire game, instead of object orientated

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * 1.5f);

        RaycastHit hit;
        //raycast parameters (origin, direction, distance)
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.5f))
        {
            if (hit.collider.GetComponent<ModelSwap>())
            {
                //Debug.Log("hit modelswap");

                //checks for both hitting e plus if the raycast is colliding with box collider
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<ModelSwap>().SwapModel();
                    ObjectsCleaned++;
                }
            }
        }
    }

}
