namespace ClassyElectronics
{
    public class Speakanator3000 : Turntable
    {
        public int Volume { get; set; }
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
    }
}