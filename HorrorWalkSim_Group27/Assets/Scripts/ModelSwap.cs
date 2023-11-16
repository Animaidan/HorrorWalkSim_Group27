using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwap : MonoBehaviour
{
    public Mesh cleaned;

    public bool isCleaned = false;

    // UI vars
    int totalCleanedObjects = 0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            MeshFilter filter = GetComponent<MeshFilter>();
            if(filter != null)
            {
                filter.mesh = cleaned;
                isCleaned = true;
            }
        }

        // after this line would go in UI
        //This will create an array of every object using this script
        ModelSwap[] cleanableObject = FindObjectsOfType<ModelSwap>();

        int cleanedObjects = 0;
        for(int index = 0; index < cleanableObject.Length; index++)
        {
            if (cleanableObject[index].isCleaned)
            {
                cleanedObjects++;
            }
        }
        totalCleanedObjects = cleanedObjects;
    }
}
