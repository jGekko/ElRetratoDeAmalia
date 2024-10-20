using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorESC3 : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al componente AudioSource para reproducir el sonido
    public bool playOnAwake = false; // Booleano para determinar si el sonido se reproduce al iniciar la escena
    public bool stopOtherAudios = true; // Booleano para determinar si se deben detener los demás audios sonando
    private static AudioSource currentlyPlayingAudioSource; // Variable estática para rastrear el AudioSource que está sonando

    void Awake()
    {
        if (playOnAwake && audioSource != null)
        {
            audioSource.Play();
            currentlyPlayingAudioSource = audioSource;
        }
    }

    public void OnPointerClickXR()
    {
        // Verificar si hay un audioSource asignado
        if (audioSource != null)
        {
            // Detener el audio que está sonando actualmente si existe y si stopOtherAudios es verdadero
            if (stopOtherAudios && currentlyPlayingAudioSource != null && currentlyPlayingAudioSource.isPlaying)
            {
                currentlyPlayingAudioSource.Stop();
            }

            // Reproducir el nuevo sonido y actualizar la referencia del AudioSource actual si stopOtherAudios es verdadero
            audioSource.Play();
            if (stopOtherAudios)
            {
                currentlyPlayingAudioSource = audioSource;
            }
        }
    }
}
