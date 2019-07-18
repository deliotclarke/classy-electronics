namespace ClassyElectronics
{
    public class Turntable
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public void Play()
        {
            IsPlaying = true;
        }
        public void Stop()
        {
            IsPlaying = false;
        }
    }
}