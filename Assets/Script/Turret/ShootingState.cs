using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingState : TurretBaseState
{
    Transform muzle;

    public override void EnterState(TurretStateManager turret,Transform muzle)
    {
        this.muzle = muzle;
    }

    public override void OnCollisionEnter(TurretStateManager turret)
    {
           
    }

    public override void UpdateState(TurretStateManager turret)
    {

        if (muzle != null)
        {
            GameObject bullet = BulletPooler.instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = muzle.position;
                bullet.SetActive(true);
            }
        }

    }
}
