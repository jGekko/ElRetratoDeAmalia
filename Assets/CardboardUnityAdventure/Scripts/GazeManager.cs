using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class GazeManager : MonoBehaviour
{
    public event Action OnGazeSelection;
    public static GazeManager Instance;

    [SerializeField] private GameObject gazeBarCanvas;
    [SerializeField] private Image fillIndicator;
    [SerializeField] private float timeForSelection = 1.0f;
    [SerializeField] private float maxGazeDistance = 10.0f;

    private float timeCounter;
    private bool runTimer;
    private RaycastHit currentHit;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        gazeBarCanvas.SetActive(false);
        fillIndicator.fillAmount = 0;
    }

    void Update()
    {
        HandleRaycast();
    }

    private void HandleRaycast()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out currentHit, maxGazeDistance))
        {
            if (currentHit.collider.CompareTag("Interactable"))
            {
                if (!runTimer)
                {
                    StartGazeSelection(); // Inicia el temporizador solo si no está ya en marcha
                }
                else
                {
                    timeCounter += Time.deltaTime;
                    UpdateGazeProgress();
                }
            }
            else
            {
                CancelGazeSelection();
            }
        }
        else
        {
            CancelGazeSelection(); // Si no hay colisión, cancela la selección
        }
    }

    public void SetUpGaze(float newTimeForSelection)
    {
        timeForSelection = newTimeForSelection;
        StartGazeSelection();
    }

    public void StartGazeSelection()
    {
        gazeBarCanvas.SetActive(true);
        runTimer = true;
        timeCounter = 0;
    }

    public void CancelGazeSelection()
    {
        gazeBarCanvas.SetActive(false);
        runTimer = false;
        timeCounter = 0;
        fillIndicator.fillAmount = 0;
    }

    private void UpdateGazeProgress()
    {
        fillIndicator.fillAmount = timeCounter / timeForSelection;

        if (timeCounter >= timeForSelection)
        {
            OnGazeSelection?.Invoke(); // Invocar el evento de selección
            CancelGazeSelection();
        }
    }
}