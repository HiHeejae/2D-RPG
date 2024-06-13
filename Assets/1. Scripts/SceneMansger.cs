using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMansger : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void LoadSceneonclick()
    {
        SceneManager.LoadScene("SelectScene");
    }
    public void gohome()
    {
        SceneManager.LoadScene("StartScene");
    }
}
