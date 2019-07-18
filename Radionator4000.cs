using System.Collections.Generic;

namespace ClassyElectronics
{
    public class Radionator4000 : Speakanator3000
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }
        public void AddFavorite()
        {
            FavoriteStations.Add(CurrentFrequency);
        }
        public void RemoveFavorite()
        {
            FavoriteStations.Remove(CurrentFrequency);
        }
    }
}