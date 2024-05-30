using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface IGrabbable 
{
    public delegate void Grab(IGrabbable item);
    public static event Grab GrabItem;

    public void Click()
    {
        GrabItem(this);
    }


}
