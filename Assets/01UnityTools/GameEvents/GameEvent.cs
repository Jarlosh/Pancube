using System;
using System.Collections.Generic;
using UnityEngine;

namespace _00Game.Scripts.GameEvents
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "SO/Events/GameEvent", order = 0)]
    public class GameEvent : ScriptableObject
    {
        private List<IGameEventListener> listeners = new List<IGameEventListener>();
        private List<Action> actionListeners = new List<Action>();

        public void Raise()
        {
            for(int i = listeners.Count - 1; i >= 0; i--)
                try
                {
                    listeners[i].OnEventRaised();
                }
                catch{}
            
            for(int i = actionListeners.Count - 1; i >= 0; i--)
                try
                {
                    actionListeners[i]();
                }
                catch{}
        }
        
        

        private void OnDestroy()
        {
            listeners.Clear();
            actionListeners.Clear();
        }

        public void RegisterListener(IGameEventListener listener)
        { listeners.Add(listener); }

        public void UnregisterListener(IGameEventListener listener)
        { listeners.Remove(listener); }
        
        public void RegisterAction(Action listener)
        { actionListeners.Add(listener); }

        public void UnregisterAction(Action listener)
        { actionListeners.Remove(listener); }
    }
}