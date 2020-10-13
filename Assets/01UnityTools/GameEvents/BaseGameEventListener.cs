using UnityEngine;

namespace _00Game.Scripts.GameEvents
{
    public abstract class BaseGameEventListener : MonoBehaviour, IGameEventListener
    {
        public GameEvent Event;

        private void OnEnable()
        { Event.RegisterListener(this); }

        private void OnDisable()
        { Event.UnregisterListener(this); }

        public abstract void OnEventRaised();
    }
}