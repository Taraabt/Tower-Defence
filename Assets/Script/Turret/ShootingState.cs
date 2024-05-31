using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingState : TurretBaseState
{
    Transform muzle;
    float delay=1f;
    long timer;
    long currentTime;
    Collider collider;
    float speed=1f;

    public override void EnterState(TurretStateManager turret,Transform muzle,Collider collider)
    {
        this.collider = collider;
        currentTime=GetCurrentTime();
        timer = currentTime + (long)delay;
        this.muzle = muzle;
    }

    public override void OnEnter(TurretStateManager turret)
    {
           
    }

    public long GetCurrentTime()
    {
        DateTimeOffset now = DateTimeOffset.UtcNow;
        long unixTimestamp = now.ToUnixTimeSeconds();
        return unixTimestamp;
    }
    public override void OnExit(TurretStateManager turret)
    {
        turret.SwitchState(turret.idleState);
    }
    public override void UpdateState(TurretStateManager turret)
    {
        if(GetCurrentTime()>=timer)
        {
            Debug.Log("shooting");
            timer =GetCurrentTime()+(long)delay;
            GameObject bullet = BulletPooler.instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = muzle.position;
                bullet.SetActive(true);
            }
        }
    }
}
