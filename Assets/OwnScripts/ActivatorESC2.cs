using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorESC2 : MonoBehaviour
{
    [Header("List of objects to activate")]
    public List<GameObject> objectsToActivate;

    [Header("List of objects to deactivate")]
    public List<GameObject> objectsToDeactivate;

    void Update()
    {
        // Check if the global variable is equal to 3
        if (GlobalVariables.scene2Counter == 3)
        {
            ActivateObjects();
            DeactivateObjects();
        }
    }

    void ActivateObjects()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }

    void DeactivateObjects()
    {
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}
