using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AddField : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;
    public GameObject WaringMent;

    // public Text[] NumberText = new Text[30];
    // public GameObject[] clone = new GameObject[30];

    public List<GameObject> clonelist = new List<GameObject>();
    public List<Text> numbertextlist = new List<Text>();

    int[] NumMax = new int[30];
 
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

          /*  clone[i] = Instantiate(OriginalPrefab, Parent);
            clone[i].name = "Clone" + NumMax[i].ToString();
            clone[i].transform.GetChild(6).name = "CloneNumber" + NumMax[i].ToString();
            clonelist = clone.ToList();
            Debug.Log(clonelist.Count);

            NumberText[i] = clone[i].transform.GetChild(6).GetComponent<Text>();
            NumberText[i].text = NumMax[i].ToString() + ".";
            numbertextlist = NumberText.ToList();
            Debug.Log(numbertextlist.Count);
          */

            clonelist.Add(Instantiate(OriginalPrefab,Parent));
            clonelist[i].name = "Clone" + NumMax[i].ToString();;

            numbertextlist.Add(clonelist[i].transform.GetChild(6).GetComponent<Text>());
            numbertextlist[i].name = "Clone" + NumMax[i].ToString();
            numbertextlist[i].text = NumMax[i].ToString() + ".";
            
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

