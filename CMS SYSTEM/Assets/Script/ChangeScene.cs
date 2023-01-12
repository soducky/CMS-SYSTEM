using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SettingAndEditBtnClik()
    {
        if (this.gameObject.tag == "Setting")
        {
            SceneManager.LoadScene("SettingScene");
        }

        else if(this.gameObject.tag == "Edit")
        {
            SceneManager.LoadScene("SettingScene");
        }
        
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
