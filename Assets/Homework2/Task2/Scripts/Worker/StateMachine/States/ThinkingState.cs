using UnityEngine;

public class ThinkingState : BasicState, IState
{
    public ThinkingState(IStateSwitcher switcher, Worker worker) : base(switcher, worker)
    {

    }

    public void Enter()
    {
        if (Worker.Stamina.IsRecovered)
        {
            if (Worker.ObjectsChecker.IsObjectNear<Workbench>())
            {
                Switcher.SwitchState<WorkingState>();
            }
            else
            {
                GoToPoint(Worker.WorkPoint.transform);
            }
        }
        else
        {
            if (Worker.ObjectsChecker.IsObjectNear<Bed>())
            {
                Switcher.SwitchState<RestingState>();
            }
            else
            {
                GoToPoint(Worker.BedPoint.transform);
            }
        }
    }

    public void Exit()
    {

    }

    public void Update()
    {

    }

    private void GoToPoint(Transform destinationPoint)
    {
        Worker.WorkerMovement.SetDestination(destinationPoint);
        Switcher.SwitchState<WalkingState>();
    }
}