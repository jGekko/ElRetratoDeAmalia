using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeleportPoint : MonoBehaviour
{
    public UnityEvent OnTeleportEnter;
    public UnityEvent OnTeleport;
    public UnityEvent OnTeleportExit;
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnterXR()
    {
        OnTeleportEnter?.Invoke();
    }

    public void OnPointerClickXR()
    {
        ExecuteTeleportation();
        OnTeleport?.Invoke();
        TelportManager.Instance.DisableTeleportPoint(gameObject);
    }

    public void OnPointerExitXR()
    {
        OnTeleportExit?.Invoke();
    }

    private void ExecuteTeleportation()
    {
        GameObject player = TelportManager.Instance.Player;
        //Convervar la pos. Y de la camara
        Vector3 targetPosition = new Vector3(transform.position.x, 2.633f,transform.position.z);
        player.transform.position = targetPosition;

        //ajustar la rotacion
        Camera camera = player.GetComponentInChildren<Camera>();
        float roty = transform.rotation.eulerAngles.y - camera.transform.localEulerAngles.y;
        player.transform.rotation = Quaternion.Euler(0, roty, 0);
    }
}
