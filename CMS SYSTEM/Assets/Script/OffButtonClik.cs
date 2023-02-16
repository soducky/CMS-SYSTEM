using PjlinkClient;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffButtonClik : MonoBehaviour
{
    string slice;
    int tmp;

    string _hostName;
    int _port;

    Button OffBtn;
    public Image GreenLight;
    public Sprite RedLight;

    void Start()
    {
        StartReady();

        OffBtn = GetComponent<Button>();
        OffBtn.onClick.AddListener(OffBtnClik);
    }

    public void StartReady()
    {
        if (DataManager.Instance.data.ImageLight == false)
        {
            ImageChange();
        }

    }

    public void OffBtnClik() 
    {
        OffBtnCapsule();
    }

    public void OffBtnCapsule()
    {
        OffBtnTitleTransfer();

        if (DataManager.Instance.data.modeSelect[tmp - 1] == true) // PC 모드 
        {
            Debug.Log("아직 준비중");
        }

        else if (DataManager.Instance.data.modeSelect[tmp - 1] == false) // PJ 모드 
        {
            _hostName = DataManager.Instance.data.IPAddress[tmp - 1];
            _port = int.Parse(DataManager.Instance.data.Port[tmp - 1]);

            if (_port == 4352)
            {
                PjlinkClient2 PJ = new PjlinkClient2(_hostName, _port, 2000);
                PJ.PowerOff();

                if (PJ.value == 2)
                {
                    ImageChange();
                    DataManager.Instance.data.ImageLight = false;
                    DataManager.Instance.SaveGameData();
                }
            }

            else
            {
                return;
            }
        }
    }

    public void OffBtnTitleTransfer()
    {
        slice = this.gameObject.name;
        String substring = slice.Substring(0, 2);
        tmp = int.Parse(substring);
    }
    public void ImageChange()
    {
        GreenLight.sprite = RedLight;
    }
}
