using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RotateObject : MonoBehaviour
{
    [SerializeField] private float rotationAngle = 90f;
    [SerializeField] private float changeRate = 180f;
    private Quaternion initialRotation;
    private bool isRotated = false;
    void Start()
    {
        initialRotation = transform.localRotation;
    }

    void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, GetTargetRotation(), changeRate * Time.deltaTime);
    }
    private Quaternion GetTargetRotation()
    {
        return isRotated ? Quaternion.Euler(rotationAngle, 0, 0) : initialRotation;
    }
    public void ToggleRotation()
    {
        isRotated = !isRotated;
    }
    // Had ChatGPT explain to me how to turn the isScaled into a rotation version of it since Unity doesn't directly have an isRotated
}
