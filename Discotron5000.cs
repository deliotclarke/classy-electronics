namespace ClassyElectronics
{
    public class Discotron5000 : Radionator4000
    {
        public int TotalTracks { get; set; }
        public int CurrentTrack { get; set; }
        public void NextTrack()
        {
            if (CurrentTrack != TotalTracks)
            {
                CurrentTrack += 1;
            }
            else
            {
                CurrentTrack = 1;
            }

            // CurrentTrack != TotalTracks ? CurrentTrack += 1 : CurrentTrack = 1;
        }
        public void PreviousTrack()
        {
            if (CurrentTrack != 1)
            {
                CurrentTrack -= 1;
            }
        }
    }
}