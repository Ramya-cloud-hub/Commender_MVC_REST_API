using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commender.Dtos
{
    public class CommandReadDto
    {
        //Core concept of DTo is Implimation of Dtos are not to expose to our clients some confidential information so I removed other property from Model class Platform  in this class
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
    }
}
