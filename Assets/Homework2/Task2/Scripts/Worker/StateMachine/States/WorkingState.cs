using UnityEngine;

public class WorkingState : BasicState, IState
{
    private float _fatigueRate;

    public WorkingState(IStateSwitcher switcher, Worker worker, float fatigueRate) : base(switcher, worker) => _fatigueRate = fatigueRate;

    public void Enter()
    {

    }

    public void Exit()
    {

    }

    public void Update()
    {
        if (Worker.Stamina.TryUseStamine(_fatigueRate * Time.deltaTime) == false)
        {
            Switcher.SwitchState<ThinkingState>();
        }
    }
}