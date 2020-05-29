using System.Collections.Generic;

namespace CarMaintenance.BIZ
{
    public class ShortTermCheckupObject
    {
        public AirFilter AirFilter { get; set; }
        public CoolantContainer CoolantContainer { get; set; }
        public OilContainer OilContainer { get; set; }
        public IEnumerable<Tire> Tires { get; set; }
    }
}