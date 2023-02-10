using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneNameLoad : MonoBehaviour
{
    public Text[] Zone1InfoText;
    void Start()
    {
        Zone1InfoText[0].text  = DataManager.Instance.data.ZoneName[0];
        Zone1InfoText[1].text = DataManager.Instance.data.ZoneName[8];
        Zone1InfoText[2].text = DataManager.Instance.data.ZoneName[16];
        Zone1InfoText[3].text = DataManager.Instance.data.ZoneName[24];
        Zone1InfoText[4].text = DataManager.Instance.data.ZoneName[32];
        Zone1InfoText[5].text = DataManager.Instance.data.ZoneName[40];
        Zone1InfoText[6].text = DataManager.Instance.data.ZoneName[48];
    }

   
    void Update()
    {
        
    }
}
