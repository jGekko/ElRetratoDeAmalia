using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_elements : MonoBehaviour
{
    public GameObject[] gameObjectsToToggle;
    // Método que se llamará cuando el botón sea presionado
    public void ToggleObjects()
    {
        foreach (GameObject obj in gameObjectsToToggle)
        {
            obj.SetActive(!obj.activeSelf); // Cambia el estado activo de cada objeto
        }
    }
}
