using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public delegate void Grab();
    public static event Grab GrabItem;

    public void Click()
    {
        GrabItem();
    }


}
