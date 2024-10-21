using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class SceneChanger : MonoBehaviour
{
    public string Tumba_1; // Nombre de la escena a la que quieres cambiar

    // Este método se ejecuta cuando ocurre una colisión
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisiona tiene la etiqueta "Player" (puedes ajustarlo según tu caso)
        if (other.CompareTag("Player"))
        {
            // Cambiar a la escena especificada
            SceneManager.LoadScene(Tumba_1);
        }
    }
}