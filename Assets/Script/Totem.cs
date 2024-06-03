using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour
{
    [SerializeField] List<GameObject> totemList=new List<GameObject>();
    [SerializeField] GameObject turret;


    private void OnMouseDown()
    {
        if (turret==Hand.instance.item&&totemList.Count==0)
        {
            Instantiate(Hand.instance.item, this.transform.position+Vector3.up*0.5f, Quaternion.identity);
            totemList.Add(Hand.instance.item);
        }
    }
}