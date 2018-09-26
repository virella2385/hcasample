using System;
using System.Collections.Generic;

namespace HcaProj.Models
{
    public class Dict_ItemTypes
    {
        public int Dict_ItemTypesId { get; set; }
        public string name { get; set; }
        public int ItemGroupTypesId { get; set; }
        public Dict_ItemGroupTypes Dict_ItemGroupTypes { get; set; }
    }
}