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
    
    private void OnPointerClickXR()
    {
        if(!hasCollide)
        {
            hasCollide = true;
            Debug.Log("Colisión detectada con: ");

            foreach(GameObject obj in objectsToRotate)
            {
                StartCoroutine(RotateObjectSmooth(obj));
            }
        }
    }

    private IEnumerator RotateObjectSmooth(GameObject obj)
    {
        
        if (obj != null)
        {
            Quaternion targetrotation = obj.transform.localRotation * Quaternion.AngleAxis(rotationAngle, rotationAxis.normalized);//calculo de rotacion del objeto

            while (Quaternion.Angle(obj.transform.localRotation, targetrotation) > 0.01f)//rotar hasta alcanzar la posición
            {
                obj.transform.localRotation=Quaternion.RotateTowards(obj.transform.localRotation, targetrotation, rotationSpeed*Time.deltaTime);//interpolacion de la animacion de rotacion
                yield return null; //espera frame a frame
            }
            
            Debug.Log("Objeto rotado");
        }
        else
        {
            Debug.Log("No hay objetos en lista");
        }
        
    }
   
}
