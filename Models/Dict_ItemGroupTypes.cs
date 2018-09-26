using System;
using System.Collections.Generic;

namespace HcaProj.Models
{
    public class Dict_ItemGroupTypes
    {
        public int Dict_ItemGroupTypesId { get; set; }
        public string GroupName { get; set; }
        public List<Dict_ItemTypes> ItemTypes { get; set; }
    }
}