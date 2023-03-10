using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameFSM : StateMachineMB
{
    private GameController _controller;
    
    public GameSetupState SetupState { get; private set; }
    public GamePlayState PlayState { get; private set; }
    public WinState WinState { get; private set; }
    
    public LoseState LoseState { get; private set; }
    
    // Start is called before the first frame update
    void Awake()
    {
        _controller = GetComponent<GameController>();
        SetupState = new GameSetupState(this, _controller);
        PlayState = new GamePlayState(this, _controller);
        WinState = new WinState(this, _controller);
        LoseState = new LoseState(this, _controller);
    }

    private void Start()
    {
        ChangeState(SetupState);
    }
}
