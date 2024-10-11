using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorESC1 : MonoBehaviour
{
    [Header("List of objects to activate")]
    public List<GameObject> objectsToActivate;

    [Header("List of objects to deactivate")]
    public List<GameObject> objectsToDeactivate;

    [Header("Rotation to check")]
    public float targetRotationY = -35f;

    void Update()
    {
        // Get the current rotation of the object on the Y axis
        float currentRotationY = transform.eulerAngles.y;

        // Adjust if the rotation exceeds 180 degrees (to handle cases where Unity uses 360 degrees for negative angles)
        if (currentRotationY > 180)
        {
            currentRotationY -= 360;
        }

        // Check if the rotation is equal to the target rotation
        if (Mathf.Approximately(currentRotationY, targetRotationY))
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