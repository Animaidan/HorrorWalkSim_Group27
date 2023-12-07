using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int RequiredCleaned;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectModelSwap.ObjectsCleaned >= RequiredCleaned)
        {
            //Open the door
            gameObject.SetActive(false);
            //lowcase g in gameObject means it will apply to whatever gameobject the script is attached to
        }
    }
}
