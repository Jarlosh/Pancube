namespace _00Game.Scripts.StateMachine
{
    public interface IState
    {
        void Tick();
        void OnStateExit();
        void OnStateEnter();
    }
}