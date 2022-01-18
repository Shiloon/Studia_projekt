using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triger enter" + other.gameObject.name);

        PickupObject pickup = other.gameObject.GetComponent<PickupObject>();

        if (pickup != null) 
        {
            pickup.OnPickupFound();
        }

    }
}
