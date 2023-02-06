using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{

   // public Button SaveButton;

    void Start()
    {
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.instance.Name.text = PlayerPrefs.GetString("Name");
            GameManager.instance.MacAddress.text = PlayerPrefs.GetString("MacAddress");
            GameManager.instance.IpAddress.text = PlayerPrefs.GetString("IpAddress");
            GameManager.instance.Port.text = PlayerPrefs.GetInt("Port").ToString();
        }
    }

    void WarmingUpSave()
    {
       /* switch (this.gameObject.name)
        {
            case "InputFieldPrefab":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone2":
                SaveButton.onClick.AddListener(Save );
                break;

            case "Clone3":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone4":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone5":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone6":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone7":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone8":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone9":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone10":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone11":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone12":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone13":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone14":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone15":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone16":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone17":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone18":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone19":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone20":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone21":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone22":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone23":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone24":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone25":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone26":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone27":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone28":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone29":
                SaveButton.onClick.AddListener(Save);
                break;

            case "Clone30":
                SaveButton.onClick.AddListener(Save);
                break;
        }*/
    }
    public void Save()
    {
      // WarmingUpSave();

        PlayerPrefs.SetString("Name", GameManager.instance.Name.text);
        PlayerPrefs.SetString("MacAddress", GameManager.instance.MacAddress.text);
        PlayerPrefs.SetString("IpAddress", GameManager.instance.IpAddress.text);
        PlayerPrefs.SetInt("Port", int.Parse(GameManager.instance.Port.text));

        Debug.Log("d");
    }

}
