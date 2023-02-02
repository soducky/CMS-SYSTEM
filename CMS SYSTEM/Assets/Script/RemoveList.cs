using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RemoveList : MonoBehaviour, IPointerClickHandler
{
    bool CheckSign = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        if(CheckSign == true)
        {
            Debug.Log(this.gameObject.name);
        }

        else if(CheckSign == false)
        {
            Debug.Log("안되는중");
        }
    }

    public void CheckSignTrue()
    {
        CheckSign= true;
    }

    public void CheckSignFalse()
    {
        CheckSign= false;
    }
}

