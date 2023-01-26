using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;


    public void PrefabAddBtn()
    {
        NumberTrans.numbertrans();
        Instantiate(OriginalPrefab, Parent);
    }
}
