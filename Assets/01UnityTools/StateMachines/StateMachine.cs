using UnityEngine;

namespace _00Game.Scripts.StateMachine
{
    public class StateMachine<StateT> : MonoBehaviour
        where StateT : IState
    {
        protected StateT currentState;
        
        protected void Update()
        {
            currentState?.Tick();
        }

        public void SetState(StateT state)
        {
            currentState?.OnStateExit();
            currentState = state;
            currentState?.OnStateEnter();
        }
    }
}