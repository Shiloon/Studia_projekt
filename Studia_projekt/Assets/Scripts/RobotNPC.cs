using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotNPC : MonoBehaviour
{
    public GameObject uiPanel;

    public void Start()
    {
        HideUI();
    }

    public void ShowUI()
    {
        uiPanel.SetActive(true);
    }

    public void HideUI()
    {
        uiPanel.SetActive(false);
    }
}
