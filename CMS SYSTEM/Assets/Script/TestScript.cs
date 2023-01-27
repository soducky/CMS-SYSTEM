using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;
    public GameObject[] clone = new GameObject[30];

    int[] NumMax = new int[30];
    public Text[] NumberText;
    int i = 1;

    void Start()
    {
        for (int k=0; k < NumMax.Length; k++)
        {
            NumMax[k] = k+1;
        }
    }
    public void PrefabAddBtn()
    {

        clone[i] = Instantiate(OriginalPrefab, Parent);
        clone[i].name = "clone"+ NumMax[i].ToString();
        NumberText[i] = clone[i].GetComponent<Text>();
      //  NumberText[i].text = NumMax[i].ToString() + ".";
        ++i;
        Debug.Log("d");

    }
}
