using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfAppCore.model
{
    [Table("Land")]
    class Land : IRealty
    {
        public int id { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string houseNumber { get; set; }
        public string apartmentNumber { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public int square { get; set; }
    }
}
