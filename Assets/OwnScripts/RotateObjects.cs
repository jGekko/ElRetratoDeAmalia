using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    public float rotationAngle;
    public Vector3 rotationAxis;
    public float rotationSpeed = 30f;
    public GameObject[] objectsToRotate;
    private bool hasCollide = false;
    public bool disableInteractableTag = false; // Checkbox para desactivar el tag interactable

    private void OnPointerClickXR()
    {
        if (!hasCollide)
        {
            hasCollide = true;
            Debug.Log("Colisión detectada con: ");

            foreach (GameObject obj in objectsToRotate)
            {
                StartCoroutine(RotateObjectSmooth(obj));
            }

            // Desactivar el tag interactable si el checkbox está activado
            if (disableInteractableTag)
            {
                gameObject.tag = "Untagged"; // Cambiar el tag a default
            }
        }
    }

    private IEnumerator RotateObjectSmooth(GameObject obj)
    {
        if (obj != null)
        {
            Quaternion targetrotation = obj.transform.localRotation * Quaternion.AngleAxis(rotationAngle, rotationAxis.normalized); // Calculo de rotacion del objeto

            while (Quaternion.Angle(obj.transform.localRotation, targetrotation) > 0.01f) // Rotar hasta alcanzar la posición
            {
                obj.transform.localRotation = Quaternion.RotateTowards(obj.transform.localRotation, targetrotation, rotationSpeed * Time.deltaTime); // Interpolacion de la animacion de rotacion
                yield return null; // Espera frame a frame
            }

            Debug.Log("Objeto rotado");
        }
        else
        {
            Debug.Log("No hay objetos en lista");
        }
    }
}
