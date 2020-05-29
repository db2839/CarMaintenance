using System;

namespace CarMaintenance.BIZ
{
    public class Vehicle
    {
        public DateTime LastUpdatedDate { get; set; }
        public LongTermCheckupObject LongTermCheckupObject { get; set; }
        public string Make { get; set; }
        public long Mileage { get; set; }
        public string Model { get; set; }
        public ShortTermCheckupObject ShortTermCheckupObject { get; set; }
        public int Year { get; set; }

        public string GetCarName() => $"{Year} {Make} {Model}";
    }
}