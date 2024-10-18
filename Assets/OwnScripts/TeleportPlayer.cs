using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField]
    private Vector3 teleportLocation;
    
    [SerializeField]
    private Quaternion teleportRotation;
    public GameObject player;
    public GameObject playerCam;

    private void OnPointerClickXR()
    {
        Teleport();
    }

    private void Teleport()
    {
        if (player != null)
        {
            player.transform.position = teleportLocation;
            player.transform.rotation = teleportRotation;
        }
    }
}
