using System;
using System.Collections.Generic;
using System.Text;

namespace State.Solution_1
{
    public class StandbyState : IState
    {
        public void PressPlay(MP3PlayerContext context)
        {
            context.CurrentState = new PlayingState();
        }
    }
}
