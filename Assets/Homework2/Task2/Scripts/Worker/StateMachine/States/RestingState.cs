using UnityEngine;

public class RestingState : BasicState, IState
{
    private float _restingSpeed;

    public RestingState(IStateSwitcher switcher, Worker worker, float restingSpeed) : base(switcher, worker) =>_restingSpeed = restingSpeed;

    public void Enter()
    {

    }

    public void Exit()
    {

    }

    public void Update()
    {
        if (Worker.Stamina.IsRecovered == false)
        {
            Worker.Stamina.RecoverStamine(_restingSpeed * Time.deltaTime);
        }
        else
        {
            Switcher.SwitchState<ThinkingState>();
        }
    }
}