using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoadObject : MonoBehaviour
{
    public GameObject[] CMSList;
    void Start()
    {
        DataManager.Instance.LoadGameData();

        for (int i = 0; i < 56; i++)
        {
            if (DataManager.Instance.data.s[i] == false)
            {
                CMSList[i].gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {

    }
}
