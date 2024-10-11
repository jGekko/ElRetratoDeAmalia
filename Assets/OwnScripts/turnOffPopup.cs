using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffPopup : MonoBehaviour
{
    public Canvas popup;                // El popup que se desactivará
    public AudioSource audioSource;     // Referencia al componente AudioSource para detener el sonido

    public void OnPointerClickXR()
    {
        // Desactivar el popup
        popup.gameObject.SetActive(false);

        // Verificar si hay un AudioSource asignado y si está reproduciendo algo
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop(); // Detener el sonido si se está reproduciendo
        }
    }
}