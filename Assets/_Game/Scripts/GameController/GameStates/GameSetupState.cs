using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameSetupState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public GameSetupState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        
        Debug.Log("STATE: Game Setup");
        Debug.Log("Load Save Data");
        Debug.Log("Spawn Units");

        // _controller.UnitSpawner.Spawn(_controller.DevPrefab, _controller.PlayerUnitSpawnLocation);
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
        
        _stateMachine.ChangeState(_stateMachine.PlayState);
    }
}
