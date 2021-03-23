using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppCore.model
{
    class House : IRealty
    {
        public int id { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string houseNumber { get; set; }
        public string apartmentNumber { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

        public int roomsAmount { get; set; }
        public int floorsAmount { get; set; }
        public int square { get; set; }
    }
}
