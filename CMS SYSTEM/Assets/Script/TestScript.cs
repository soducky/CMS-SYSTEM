using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;

    int[] NumMax = new int[31];
    public Text[] NumberText;
    int i = 0;

    private void Start()
    {
        Text NumberText = GetComponent<Text>();

        for (int i = 1; i < NumMax.Length; i++)
        {
            NumMax[i] = i;
        }
    }

    public void PrefabAddBtn()
    {

        ++i;
        NumberText[i].text= "0"+ NumMax[i].ToString() + ".";

        Instantiate(OriginalPrefab, Parent);
        // NumberCount();
    }


}
