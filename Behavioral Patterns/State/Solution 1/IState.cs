using System;
using System.Collections.Generic;
using System.Text;

namespace State.Solution_1
{
    public interface IState
    {
        void PressPlay(MP3PlayerContext context);
    }
}
