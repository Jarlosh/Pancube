using UnityEngine;

namespace _00Game.Scripts.StateMachine
{
    public abstract class StateAbc<Self, MachineT> : MonoBehaviour, IState
        where MachineT: StateMachine<Self> 
        where Self : StateAbc<Self, MachineT>
    {
        [SerializeField] protected MachineT machine;
        public abstract void Tick();

        public virtual void OnStateExit() { }

        public virtual void OnStateEnter() { }
    }
}