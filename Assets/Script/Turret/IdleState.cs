using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : TurretBaseState
{
    public override void EnterState(TurretStateManager turret,Transform muzle,Collider collider)
    {
    }

    public override void OnEnter(TurretStateManager turret)
    {
        turret.SwitchState(turret.shootingState);
    }

    public override void OnExit(TurretStateManager turret)
    {
    }

    public override void UpdateState(TurretStateManager turret)
    {
        Debug.Log("idling");
    }
}
