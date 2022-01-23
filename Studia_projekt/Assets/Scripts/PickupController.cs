using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupController : MonoBehaviour
{

    public TextMeshProUGUI pickupCountMesh;

    private int pickupFoundCount = 0;
    private int pickupOnMapCount = 3;

    private void Start()
    {
        pickupCountMesh.text = pickupFoundCount + " / " + pickupOnMapCount;
    }

    public bool GotAllPickups()
    {
        if(pickupFoundCount< pickupOnMapCount)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triger enter" + other.gameObject.name);

        PickupObject pickup = other.gameObject.GetComponent<PickupObject>();

        if (pickup != null) 
        {
            pickup.OnPickupFound();
            pickupFoundCount++;

            pickupCountMesh.text = pickupFoundCount + " / " + pickupOnMapCount;
        }

    }
}
