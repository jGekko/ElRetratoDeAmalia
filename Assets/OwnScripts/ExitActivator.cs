using System.Collections;
using UnityEngine;

public class ExitActivator : MonoBehaviour
{
    public GameObject exit; // Objeto de salida que se activará
    public bool activateExit = false; // Booleano para activar la salida

    void Update()
    {
        if (activateExit)
        {
            activateExit = false; // Resetear el booleano para evitar múltiples activaciones
            StartCoroutine(ActivateExitAfterDelay());
        }
    }

    private IEnumerator ActivateExitAfterDelay()
    {
        // Esperar 22 segundos
        yield return new WaitForSeconds(24f);
        if (exit != null)
        {
            Debug.Log("salida activada");
            exit.SetActive(true); // Activar salida
        }
    }
}
