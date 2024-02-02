using UnityEngine;

public class WalkingState : IState
{
    private readonly IStateSwitcher _switcher;
    private Worker _worker;

    public WalkingState(IStateSwitcher switcher, Worker worker)
    {
        _switcher = switcher;
        _worker = worker;
    }

    public void Enter()
    {
        _worker.MoveToPoint(Vector3.zero);
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}