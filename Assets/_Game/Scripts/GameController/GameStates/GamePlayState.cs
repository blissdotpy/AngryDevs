using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public GamePlayState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        
        Debug.Log("STATE: Game Play");
        Debug.Log("Listen for Player Inputs");
        Debug.Log("Display Player HUD");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();
        
        // _controller.TouchManager.touchInput = _controller.Input.IsTapPressed;
        _controller.TouchManager.CheckOnDevPressed();
        /*
        if (_controller.TouchManager.win)
        {
            Debug.Log("You Win!");
        }
        else if (_controller.TouchManager.lose)
        {
            Debug.Log("You Lose");
        }
        */
    }
}
