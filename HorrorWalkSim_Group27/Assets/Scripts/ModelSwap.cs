using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwap : MonoBehaviour
{
    public Mesh cleaned;
    public Material[] newMaterials;
    public bool isCleaned = false;

    // UI vars
    int totalCleanedObjects = 0;

    private void Update()
    {
        

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

    public void SwapModel()
    {
        MeshFilter filter = GetComponent<MeshFilter>();
            if(filter != null)
            {
                filter.mesh = cleaned;
                isCleaned = true;

                if(newMaterials != null && newMaterials.Length > 0)
                {
                    GetComponent<MeshRenderer>().materials = newMaterials;
                }
            }
    }
}
