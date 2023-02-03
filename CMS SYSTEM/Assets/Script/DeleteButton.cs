using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class DeleteButton : MonoBehaviour
{
    public Image scrollView;
    public BoxCollider2D InputFieldPrefab;
    public GameObject addButton;

    public List<BoxCollider2D> boxcolliderlist = new List<BoxCollider2D>();

    public bool count = false;

    public void DeleteButtonClik()
    {
        if (count == false)
        {
 
            List<GameObject> clonelist = GameObject.Find("AddButton").GetComponent<AddButton>().clonelist;

            addButton.SetActive(false);

            GameObject.Find("InputFieldPrefab").GetComponent<RemoveList>().CheckSignTrue();

            for (int j = 2; j <= clonelist.Count; j++)
            {
                GameObject.Find("Clone" + j).GetComponent<RemoveList>().CheckSignTrue();
            }

            ChangeColor();

            for (int k = 1; k <= clonelist.Count; k++)
            {
                boxcolliderlist.Add(clonelist[k].GetComponent<BoxCollider2D>());
                boxcolliderlist[k].name = clonelist[k].name;

                if (boxcolliderlist.Count == clonelist.Count)
                {
                    break;
                }
            }

            count = true;
        }

        else if (count == true)
        {
            ChangeColor();
            addButton.SetActive(true);
            GameObject.Find("InputFieldPrefab").GetComponent<RemoveList>().CheckSignFalse();

            try
            {
                for (int j = 2; j <= boxcolliderlist.Count; j++)
                {
                    GameObject.Find("Clone" + j).GetComponent<RemoveList>().CheckSignFalse();
                }
            }

            catch(Exception ex)
            {
                Debug.Log(ex);

                List<GameObject> clonelist = GameObject.Find("AddButton").GetComponent<AddButton>().clonelist;

            }

            count = false;
            boxcolliderlist.Clear();
            boxcolliderlist.Add(InputFieldPrefab);
        }

    }

    void ChangeColor()
    {
        if (count == false)
        {
            scrollView.color = new Color(255f / 255f, 0f / 255f, 0f / 255f, 100f / 255f);
        }
        else if (count == true)
        {
            scrollView.color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 100f / 255f);
        }
    }
}

