using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorImage : MonoBehaviour
{
    public Image[] colorParts; // Array de partes coloreadas
    public Button[] interactionPoints; // Botones que representan puntos de interacción

    private void Start()
    {
        // Inicialmente ocultar todas las partes coloreadas
        foreach (Image part in colorParts)
        {
            part.gameObject.SetActive(false);
        }

        // Asignar eventos de clic a los puntos de interacción
        for (int i = 0; i < interactionPoints.Length; i++)
        {
            int index = i; 
            interactionPoints[i].onClick.AddListener(() => ShowColorPart(index));
        }
    }

    private void ShowColorPart(int index)
    {
        if (index >= 0 && index < colorParts.Length)
        {
            colorParts[index].gameObject.SetActive(true);
        }
    }
}
