public interface IGameStates
{
    public void Enter();
    public void Tick();
    public void FixedTick();
    public void Exit();
}

public class StateMachine
{
    public IGameStates CurrentState { get; private set; }

    public void ChangeState(IGameStates newState)
    {
        CurrentState?.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }

    public void Tick() => CurrentState?.Tick();
    public void FixedTick() => CurrentState?.FixedTick();
}