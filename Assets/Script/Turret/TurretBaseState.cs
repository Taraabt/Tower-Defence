using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretBaseState 
{

    public abstract void EnterState(TurretStateManager turret,Transform muzle,Collider collider);


    public abstract void UpdateState(TurretStateManager turret);

    public abstract void OnEnter(TurretStateManager turret);

    public abstract void OnExit(TurretStateManager turret);

}
