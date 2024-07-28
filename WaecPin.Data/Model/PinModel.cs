using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WaecPin.Common.Enums;

namespace WaecPin.Data.Model
{
    public class PinModel : BaseEntity
    {
        public string Pin { get; set; }
        public Status Status { get; set; }
    }
}
