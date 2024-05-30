using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Enemy enemytarget;
    public void Start()
    {
        transform.Translate(enemytarget.transform.position);
    }
}
