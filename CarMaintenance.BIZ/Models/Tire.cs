using System;

namespace CarMaintenance.BIZ
{
    public class Tire
    {
        public DateTime LastChangedDate { get; set; }
        public DateTime NextCheckingDate { get; set; }
        public TirePositions Position { get; set; }
        public DateTime PreviouslyCheckedDate { get; set; }
        public int TireDepth { get; set; }
        public int TirePressure { get; set; }
    }
}