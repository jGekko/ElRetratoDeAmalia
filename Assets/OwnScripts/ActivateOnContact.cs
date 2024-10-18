using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnContact : MonoBehaviour
{
    public GameObject _cam;
    public Transform player; 
    public Vector3 position = new Vector3 (-0.083f, 0.109f, 0.4067f);
    void Update()
    {
        if (player.position == position)
        {
            Debug.Log("camara activada");
            _cam.SetActive(true); // Activar camara
        }
    }
}
