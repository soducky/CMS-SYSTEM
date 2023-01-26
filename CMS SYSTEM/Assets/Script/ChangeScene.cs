using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SettingBtnClik()
    {
            SceneManager.LoadScene("SettingScene");
     
    }

    public void EditBtn()
    {
        SceneManager.LoadScene("EditScene");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
