using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DeleteField : MonoBehaviour
{
    public Image scrollView;

    public List<BoxCollider2D> boxcolliderlist = new List<BoxCollider2D>();

    bool count = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

    }

    public void DeleteButton()
    {
        if (count == false)
        {
            List<GameObject> clonelist = GameObject.Find("AddButton").GetComponent<AddField>().clonelist;

            scrollView.color = new Color(255f / 255f, 0f / 255f, 0f / 255f, 100f / 255f);

            for (int k = 0; k <= clonelist.Count; k++)
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
            scrollView.color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 100f / 255f);
            count = false;
            boxcolliderlist.Clear();
        }

    }
}

