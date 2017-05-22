using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveReminder.Core.Models
{
    public class LoveReminder
    {
        public LoveQuote CurrentQuote { get; set; }
        public string ImagePath { get; set; }
        public DateTime TimeReminded { get; set; }
        public string SentBy { get; set; }

    }
}
