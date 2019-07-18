namespace ClassyElectronics
{
    public class Discblaster6000
    {
        public int Volume { get; set; }
        public int TotalTracks { get; set; }
        public int CurrentTrack { get; set; }
        public string VolumeUp()
        {
            if (Volume <= 10)
            {
                Volume += 1;
                return $"Volume is at {Volume}";
            }
            else
            {
                return $"Volue is MAXXXXED out";
            }
        }
        public string VolumeDown()
        {
            if (Volume >= 0)
            {
                Volume -= 1;
                return $"Volume is at {Volume}";
            }
            else
            {
                return $"It's already at {Volume}! It can't go any lower!";
            }
        }
        public void NextTrack()
        {
            // if (CurrentTrack != TotalTracks)
            // {
            //     CurrentTrack += 1;
            // }
            // else
            // {
            //     CurrentTrack = 1;
            // }

            //finally a ternary that actually does something
            CurrentTrack = (CurrentTrack != TotalTracks) ? CurrentTrack + 1 : 1;
        }
        public void PreviousTrack()
        {
            // if (CurrentTrack != 1)
            // {
            //     CurrentTrack -= 1;
            // }

            //finally a ternary that also actually does something
            CurrentTrack = (CurrentTrack != 1) ? CurrentTrack - 1 : 1;
        }
    }
}