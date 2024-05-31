using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretStateManager : MonoBehaviour
{

    [SerializeField] Transform muzle;
    TurretBaseState currentState;
    public IdleState idleState=new IdleState();
    public ShootingState shootingState=new ShootingState();
    Collider collider;

    private void Start()
    {
        currentState=idleState;
        currentState.EnterState(this,muzle,collider);
    }

    private void Update()
    {

        currentState.UpdateState(this);
    }


    public void SwitchState(TurretBaseState state)
    {
        currentState = state;
        state.EnterState(this,muzle,collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        collider=other.GetComponent<Collider>();
        currentState.OnEnter(this);
    }
    private void OnTriggerExit(Collider other)
    {
        currentState.OnExit(this);
    }
}
