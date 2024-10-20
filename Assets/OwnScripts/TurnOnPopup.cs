using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPopup : MonoBehaviour
{
    public Canvas popup;                  // El popup que se activará
    public bool playSoundOnClick = false; // Booleano para activar o desactivar el sonido desde el Inspector
    public AudioSource audioSource;       // Referencia al componente AudioSource para reproducir el sonido
    public bool disableInteractableTag = false; // Checkbox para desactivar el tag interactable
    public bool scene2 = false;           // Variable para determinar si es la escena 2
    public bool isFinalAudio = false;     // Booleano para determinar si este es el audio final
    public ExitActivator exitActivator;   // Referencia al script ExitActivator

    private static AudioSource currentlyPlayingAudioSource; // Variable estática para rastrear el AudioSource que está sonando

    public void OnPointerClickXR()
    {
        // Si es el audio final, establecer activateExit en true
            if (isFinalAudio && exitActivator != null)
            {
                exitActivator.activateExit = true;
            }
            
        // Activar el popup
        if (popup != null)
        {
            popup.gameObject.SetActive(true);
        }

        // Verificar si el sonido está habilitado y si hay un audioSource asignado
        if (playSoundOnClick && audioSource != null)
        {
            // Detener el audio que está sonando actualmente si existe
            if (currentlyPlayingAudioSource != null && currentlyPlayingAudioSource.isPlaying)
            {
                currentlyPlayingAudioSource.Stop();
            }

            // Reproducir el nuevo sonido y actualizar la referencia del AudioSource actual
            audioSource.Play();
            currentlyPlayingAudioSource = audioSource;
        }

        // Desactivar el tag interactable si el checkbox está activado
        if (disableInteractableTag)
        {
            gameObject.tag = "Untagged"; // Cambiar el tag a default
        }

        // Incrementar el contador si es la escena 2
        if (scene2)
        {
            GlobalVariables.scene2Counter++;
        }
    }
}
