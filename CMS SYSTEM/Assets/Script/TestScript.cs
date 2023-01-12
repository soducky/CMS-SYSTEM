using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject OriginalPrefab;
    public Transform Parent;


    public void PrefabAddBtn()
    {
        Instantiate(OriginalPrefab, Parent);    
    }
}
