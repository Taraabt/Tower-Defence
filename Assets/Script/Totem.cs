using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour
{
    List<GameObject> totemList=new List<GameObject>();
    [SerializeField] GameObject turret;
    [SerializeField] GameObject buff;

    private void OnMouseDown()
    {
        if (turret==Hand.instance.item&&totemList.Count>=0)
        {
            GameObject instance=Instantiate(Hand.instance.item, this.transform.position+Vector3.up*totemList.Count, Quaternion.identity);
            totemList.Add(Hand.instance.item);
            Hand.instance.item = null;
        }else if (buff == Hand.instance.item&&totemList.Count>=1)
        {
            GameObject instance=Instantiate(Hand.instance.item, this.transform.position + Vector3.up * totemList.Count, Quaternion.identity);
            totemList.Add(Hand.instance.item);
            Hand.instance.item = null;
        }else if (totemList.Count>0 &&Hand.instance.item==null)
        {
            Hand.instance.item = totemList[^1];
            totemList.Count.CompareTo(^1);
        }
    }
}