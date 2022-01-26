using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public AudioSource pickupSound;
    public float rotationSpeed = 1.0f;
    public GameObject pickupModel;

    private bool isFound = false;

    void Update()
    {
        transform.Rotate(0.0f, 1.0f, 0.0f);
    }

    public void OnPickupFound()
    {
        if (isFound == false)
        {
            isFound = true;
            pickupModel.SetActive(false);
            pickupSound.Play();
        }
    }
}
