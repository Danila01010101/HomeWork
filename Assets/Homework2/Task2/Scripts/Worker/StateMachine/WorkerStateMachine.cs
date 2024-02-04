using System.Collections.Generic;
using System.Linq;

public class WorkerStateMachine : IStateSwitcher
{
    private List<IState> _states = new List<IState>();
    private IState _currentState;

    public WorkerStateMachine(Worker worker, WorkerConfig workerConfig)
    {
        _states = new List<IState>()
        {
            new ThinkingState(this, worker),
            new WalkingState(this, worker),
            new RestingState(this, worker, workerConfig.RestingSpeed),
            new WorkingState(this, worker, workerConfig.FatigueRate)
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState newState = _states.FirstOrDefault(state => state is T);

        _currentState?.Exit();
        _currentState = newState;
        _currentState.Enter();
    }

    public void Update() => _currentState.Update();
}