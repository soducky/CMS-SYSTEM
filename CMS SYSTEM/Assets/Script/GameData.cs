using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


[Serializable] // 직렬화

public class Data
{
    public int i = 1;
   // public int s;

    public List<String> Name = new List<String>();
    public List<String> MacAddress = new List<String>();
    public List<String> IPAddress = new List<String>();
    public List<string> Port = new List<string>();
}