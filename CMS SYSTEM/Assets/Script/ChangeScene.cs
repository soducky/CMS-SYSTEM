using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{

    public void StartChangeScene()
    {
            AutoLoadMainScene();
    }

    public void SettingBtnClik()
    {
        SceneManager.LoadScene("SettingScene");
     
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void AutoLoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
