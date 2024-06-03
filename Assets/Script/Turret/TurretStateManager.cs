using UnityEngine;

public class TurretStateManager : MonoBehaviour
{

    [SerializeField] Transform muzle;
    TurretBaseState currentState;
    public IdleState idleState=new IdleState();
    public ShootingState shootingState=new ShootingState();
    public Collider enemy;
    public float speed;

    private void Start()
    {
        currentState=idleState;
        currentState.EnterState(this,muzle,enemy);
    }
    private void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(TurretBaseState state)
    {
        currentState = state;
        state.EnterState(this,muzle,enemy);
    }
    private void OnTriggerEnter(Collider other)
    {
        enemy=other.GetComponent<Collider>();
        currentState.OnEnter(this);
    }
    private void OnTriggerExit(Collider other)
    {
        currentState.OnExit(this);
    }
}
