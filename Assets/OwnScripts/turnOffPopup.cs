using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffPopup : MonoBehaviour
{
    public Canvas popup;
    public void OnPointerClickXR()
    {
        popup.gameObject.SetActive(false);
    }
}
