using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupCuadros : MonoBehaviour
{
    public Canvas popup;                  // El popup que se activará
    public bool playSoundOnClick = false; // Booleano para activar o desactivar el sonido desde el Inspector
    public AudioSource audioSource;       // Referencia al componente AudioSource para reproducir el sonido
    private static bool hasPlayed = false; // Variable estática para controlar si el sonido ya se ha reproducido

    public void OnPointerClickXR()
    {
        // Activar el popup
        popup.gameObject.SetActive(true);

        // Verificar si el sonido está habilitado, si hay un audioSource asignado y si el sonido no se ha reproducido antes
        if (playSoundOnClick && audioSource != null && !hasPlayed)
        {
            audioSource.Play(); // Reproducir el sonido
            hasPlayed = true;   // Marcar que el sonido ya se ha reproducido
        }
    }
}
