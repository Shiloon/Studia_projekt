using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnStartClicked()
    {
        Debug.Log("Start clicked");
        SceneManager.LoadScene("SampleScene");
    }

    public void OnQuitClicked()
    {
        Debug.Log("Start clicked");
        Application.Quit();
    }
}
