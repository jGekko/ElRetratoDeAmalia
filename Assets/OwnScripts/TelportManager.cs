using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelportManager : MonoBehaviour
{
    public static TelportManager Instance;
    public GameObject Player;
    public GameObject lastTelPoint;

    private void Awake() 
    {
        if(Instance != this && Instance !=null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        
    }

    public void DisableTeleportPoint(GameObject TeleportPoint)
    {
        if(lastTelPoint != null)
        {
            lastTelPoint.SetActive(true);
            
        }

        TeleportPoint.SetActive(false);
        lastTelPoint=TeleportPoint;

#if UNITY_EDITOR
    Player.GetComponent<CardboardSimulator>().UpdatePlayerPositonSimulator();
#endif
    }

   
}
