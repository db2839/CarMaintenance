using System;

namespace CarMaintenance.BIZ
{
    public class CoolantContainer
    {
        public DateTime LastChangedDate { get; set; }
        public DateTime NextCheckingDate { get; set; }
        public DateTime PreviouslyCheckedDate { get; set; }
    }
}