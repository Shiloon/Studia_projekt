using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotNPC : MonoBehaviour
{
    public GameObject uiPanel;
    public GameObject questStarted;
    public GameObject questFinished;
    public PickupController pickupController;
    public Animator doorAnimator;
    private bool isQuestFinished = false;
    private bool isPlayerNear = false;

    public void Start()
    {
        HideUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true && isPlayerNear == true)
        {
            if (pickupController.GotAllPickups() == false)
            {
                questStarted.SetActive(true);
                questFinished.SetActive(false);
            }
            else 
            {
                doorAnimator.Play("DoorOpen");
                questStarted.SetActive(false);
                questFinished.SetActive(true);
            }
        }
    }
    public void ShowUI()
    {
        uiPanel.SetActive(true);
        isPlayerNear = true;
    }

    public void HideUI()
    {
        isPlayerNear = false;
        uiPanel.SetActive(false);
        questStarted.SetActive(false);
        questFinished.SetActive(false);
    }
}
