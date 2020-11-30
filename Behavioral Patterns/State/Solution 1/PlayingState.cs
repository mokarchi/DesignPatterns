using System;
using System.Collections.Generic;
using System.Text;

namespace State.Solution_1
{
    public class PlayingState : IState
    {
        public void PressPlay(MP3PlayerContext context)
        {
            context.CurrentState = new StandbyState();
        }
    }
}
