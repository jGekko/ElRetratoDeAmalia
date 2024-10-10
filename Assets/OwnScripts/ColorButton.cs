using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    private Button interactionButton;

    private void Awake()
    {
        interactionButton = GetComponent<Button>();
    }

    public void OnPointerClickXR()
    {
        if (interactionButton != null)
        {
            interactionButton.onClick.Invoke();
        }
    }
}
