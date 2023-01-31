using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AddField : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;

    public GameObject WaringMent;

    public GameObject[] clone = new GameObject[30];
    List<GameObject> clonelist = new List<GameObject>();

    int[] NumMax = new int[30];
    public Text[] NumberText = new Text[30];
 
    int i = 1;
    bool Switch = true;

    void Start()
    {
        for (int k=0; k < NumMax.Length; k++)
        {
            NumMax[k] = k+1;
        }
    }
    public void PrefabAddBtn()
    {
        if (Switch == true)
        {
            clone[i] = Instantiate(OriginalPrefab, Parent);
            clone[i].name = "Clone" + NumMax[i].ToString();
            clone[i].transform.GetChild(6).name = "CloneNumber" + NumMax[i].ToString();
            clonelist = clone.ToList();

            NumberText[i] = clone[i].transform.GetChild(6).GetComponent<Text>();
            NumberText[i].text = NumMax[i].ToString() + ".";

            i++;

            if (i == 30)
            {
                Switch = false;
            }
        }

        else if(Switch == false)
        {
            WaringMent.SetActive(true);
            Invoke("TimeDelay", 2f);
        }

    }

    void TimeDelay()
    {
        WaringMent.SetActive(false);
    }
}

