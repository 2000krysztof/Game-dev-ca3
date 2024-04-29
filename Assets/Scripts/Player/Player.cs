using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerBaseState _currentState;
    public PlayerRunningState runningState;
    public PlayerIdleState idleState;
    public PlayerDraggingState draggingState;


    [SerializeField] private float moveSpeed = 10f;

    void Start()
    {
        draggingState = new PlayerDraggingState();
        runningState = new PlayerRunningState();
        idleState = new PlayerIdleState();
        switchState(idleState);
    }

    void Update()
    {
       _currentState.update(this); 
    }

    public void switchState(PlayerBaseState state)
    {
        state.enter(this);
        _currentState = state;
    }
    
    
}
