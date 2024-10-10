using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPopup : MonoBehaviour
{
    public Canvas popup;
    public void OnPointerClickXR()
    {
        popup.gameObject.SetActive(true);
    }
}
