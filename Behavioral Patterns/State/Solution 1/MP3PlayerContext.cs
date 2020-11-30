namespace State.Solution_1
{
    public class MP3PlayerContext
    {
        public MP3PlayerContext()
        {
            this.CurrentState = new StandbyState();
        }

        public MP3PlayerContext(IState state)
        {
            this.CurrentState = state;
        }

        public IState CurrentState { get; set; }

        public void Play()
        {
            this.CurrentState.PressPlay(this);
        }
    }
}