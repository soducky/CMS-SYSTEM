using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectToggle : MonoBehaviour
{
    Toggle toggles;
    public GameObject cms_solo;

    private void Start()
    {
        toggles= GetComponent<Toggle>();

        toggles.onValueChanged.AddListener(OnToggleValueChanged);
    }

    public void OnToggleValueChanged(bool boolean)
    {
        cms_solo.SetActive(boolean);
    }
}
