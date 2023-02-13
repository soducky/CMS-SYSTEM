using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZoneNameTitle : MonoBehaviour
{
    public Text[] ZoneName_Title;
    void Start()
    {
        ZoneName_Title[0].text = DataManager.Instance.data.ZoneName[0];
        ZoneName_Title[1].text = DataManager.Instance.data.ZoneName[8];
        ZoneName_Title[2].text = DataManager.Instance.data.ZoneName[16];
        ZoneName_Title[3].text = DataManager.Instance.data.ZoneName[24];
        ZoneName_Title[4].text = DataManager.Instance.data.ZoneName[32];
        ZoneName_Title[5].text = DataManager.Instance.data.ZoneName[40];
        ZoneName_Title[6].text = DataManager.Instance.data.ZoneName[48];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
