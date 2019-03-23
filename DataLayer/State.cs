using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class State : BaseDataClass
    {
        public string StateName { get; set; }
        public int? PreviousStateId { get; set; }
    }
}
