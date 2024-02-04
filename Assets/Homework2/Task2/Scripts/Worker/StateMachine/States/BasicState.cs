public abstract class BasicState
{
    protected readonly IStateSwitcher Switcher;
    protected readonly Worker Worker;

    public BasicState(IStateSwitcher switcher, Worker worker)
    {
        Switcher = switcher;
        Worker = worker;
    }
}