using UnityEngine;

public class Hand : MonoBehaviour
{
   

    public static Hand instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance =this;
        }
    }

    public GameObject item;

}
