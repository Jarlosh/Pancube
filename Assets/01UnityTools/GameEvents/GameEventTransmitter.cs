using UnityEngine.Events;

namespace _00Game.Scripts.GameEvents
{
    public class GameEventTransmitter : BaseGameEventListener
    {
        public GameEvent Response;

        public override void OnEventRaised()
        { Response.Raise(); }
    }
}