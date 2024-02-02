using System.Collections.Generic;
using System.Linq;

public class WorkerStateMachine : IStateSwitcher
{
    private List<IState> _states = new List<IState>();
    private IState _currentState;

    public WorkerStateMachine()
    {
        _states = new List<IState>()
        {

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

    public void HandleInput() => _currentState.HandleInput();
}