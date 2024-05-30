using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretBaseState
{

    public abstract void EnterState(TurretStateManager turret,Transform muzle);


    public abstract void UpdateState(TurretStateManager turret);

    public abstract void OnCollisionEnter(TurretStateManager turret);


}
