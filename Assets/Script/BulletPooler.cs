using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour
{

    public List<GameObject> objects = new List<GameObject>();
    [SerializeField] int numberOfObjects = 10;
    public static BulletPooler instance;
    [SerializeField] GameObject bullet;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
            for (int j = 0; j < numberOfObjects; j++)
            {
                GameObject obj = Instantiate(bullet);
                obj.SetActive(false);
                objects.Add(obj);
            }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i <objects.Count; i++)
        {
            if (!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
        }
        return null;
    }

}
