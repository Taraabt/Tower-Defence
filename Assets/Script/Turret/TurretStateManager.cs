using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretStateManager : MonoBehaviour
{

    [SerializeField] Transform muzle;
    TurretBaseState currentState;
    public IdleState idleState=new IdleState();
    public ShootingState shootingState=new ShootingState();

    private void Start()
    {
        currentState=idleState;
        currentState.EnterState(this,muzle);
    }

    private void Update()
    {

        currentState.UpdateState(this);
    }


    public void SwitchState(TurretBaseState state)
    {
        currentState = state;
        state.EnterState(this, muzle);
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnCollisionEnter(this);
    }
}
