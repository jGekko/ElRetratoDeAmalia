using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{

    public string objectName;

    private void OnSelected()
    {
        Debug.Log($"{objectName} has been selected.");
    }
}