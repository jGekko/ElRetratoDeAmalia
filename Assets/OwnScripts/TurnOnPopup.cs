using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPopup : MonoBehaviour
{
    public Canvas popup;                  // El popup que se activará
    public bool playSoundOnClick = false; // Booleano para activar o desactivar el sonido desde el Inspector
    public AudioSource audioSource;       // Referencia al componente AudioSource para reproducir el sonido

    public void OnPointerClickXR()
    {
        // Activar el popup
        popup.gameObject.SetActive(true);

        // Verificar si el sonido está habilitado y si hay un audioSource asignado
        if (playSoundOnClick && audioSource != null)
        {
            audioSource.Play(); // Reproducir el sonido
        }
    }
}