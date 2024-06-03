using UnityEngine;

public class Buttons :MonoBehaviour
{

    public GameObject turret;
    public GameObject buff;
    public void GrabTurret()
    {
        Hand.instance.item = turret;
    }

    public void GrabBuff()
    {
        Hand.instance.item = buff;
    }
}
