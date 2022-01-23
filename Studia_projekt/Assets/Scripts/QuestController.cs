using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triger enter" + other.gameObject.name);
        RobotNPC npc = other.gameObject.GetComponent<RobotNPC>();

        if (npc != null)
        {
            npc.ShowUI();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        RobotNPC npc = other.gameObject.GetComponent<RobotNPC>();

        if (npc != null)
        {
            npc.HideUI();
        }

    }
}
