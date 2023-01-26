using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class NumberTrans : MonoBehaviour
    {
    public static Action numbertrans;

        int[] NumMax = new int[31];
        public Text[] NumberText;
        int i = 0;

    private void Awake()
    {
        numbertrans = () => { NumberPlus(); };
    }
    void Start()
        {
            for (int i = 1; i < NumMax.Length; i++)
            {
                NumMax[i] = i;
            }
        }


        public void NumberPlus()
        {
            ++i;
            NumberText[i].text = "0" + NumMax[i].ToString() + ".";
        }
    }

