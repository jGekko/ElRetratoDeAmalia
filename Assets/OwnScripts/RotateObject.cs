using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public BoxCollider Box;
    public float rotationSpeed = 10f;
    public float targetRotationX = 0f;
    public float targetRotationY = 0f;
    public bool rotateOnX = false;
    public bool rotateOnY = true;
    private bool isRotating = false;

    private void Update()
    {
        if (isRotating)
        {
            Rotate();
        }
    }

    public void OnPointerClickXR()
    {
        StartInteraction();
    }

    private void StartInteraction()
    {
        Box.enabled = false;
        isRotating = true;
    }

    private void Rotate()
    {
        if (rotateOnX && Mathf.Abs(transform.rotation.eulerAngles.x - targetRotationX) > 0.1f)
        {
            float rotationStep = rotationSpeed * Time.deltaTime;
            float currentRotationX = Mathf.MoveTowardsAngle(transform.rotation.eulerAngles.x, targetRotationX, rotationStep);
            transform.rotation = Quaternion.Euler(currentRotationX, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
        else if (rotateOnY && Mathf.Abs(transform.rotation.eulerAngles.y - targetRotationY) > 0.1f)
        {
            float rotationStep = rotationSpeed * Time.deltaTime;
            float currentRotationY = Mathf.MoveTowardsAngle(transform.rotation.eulerAngles.y, targetRotationY, rotationStep);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, currentRotationY, transform.rotation.eulerAngles.z);
        }
        else
        {
            isRotating = false;
        }
    }
}
