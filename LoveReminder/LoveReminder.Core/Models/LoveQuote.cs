using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Core.Models
{
    public class LoveQuote
    {
        public int QuoteID { get; set; }
        public string QuoteText { get; set; }
        public string QuoteAuthor { get; set; }        
        public List<LoveReminderGroup> LoveReminderGroups { get; set; }        
    }
}
