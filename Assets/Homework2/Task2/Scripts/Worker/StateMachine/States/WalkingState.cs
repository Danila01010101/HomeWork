public class WalkingState : BasicState, IState
{
    public WalkingState(IStateSwitcher switcher, Worker worker) : base(switcher, worker)
    {

    }

    public void Enter()
    {
    }

    public void Exit()
    {
    }

    public void Update()
    {
        if (Worker.WorkerMovement.HasReachedDestination())
        {
            Switcher.SwitchState<ThinkingState>();
        }
    }
}