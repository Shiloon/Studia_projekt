using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    int pickupFoundCount = 0;
    public TextMeshProUGUI pickupCountMesh;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triger enter" + other.gameObject.name);

        PickupObject pickup = other.gameObject.GetComponent<PickupObject>();

        if (pickup != null) 
        {
            pickup.OnPickupFound();
            pickupFoundCount++;

            pickupCountMesh.text = pickupFoundCount.ToString();
        }

    }
}
