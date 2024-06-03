using UnityEngine;

public class Buttons :MonoBehaviour
{

    public GameObject turret;
    
    public void GrabTurret()
    {
        Hand.instance.item = turret;
    }

}
