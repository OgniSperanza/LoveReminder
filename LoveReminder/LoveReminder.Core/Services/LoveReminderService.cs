using Main.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Core.Services
{
    class LoveReminderService
    {
        public LoveReminderService()
        {

        }

        public LoveQuote GetLoveQuote()
        {
            return new LoveQuote()
            {
                QuoteText = "You're the best wife EVER!",
                QuoteAuthor = "Jacob Barnes",
                QuoteID = 2,
                LoveReminderGroups = new List<LoveReminderGroup>()
                {
                    new LoveReminderGroup()
                    {
                        GroupName = "Wife"
                    }
                }
            };
        }

        public LoveReminder GetLoveReminder()
        {
            //return new LoveReminder()
            //{
            //    CurrentQuote = new LoveQuote()
            //    {
            //        QuoteText = "You're the best wife EVER!",
            //        QuoteAuthor = "Jacob Barnes",
            //        QuoteID = 2,
            //        LoveReminderGroups = new List<LoveReminderGroup>()
            //        {
            //            new LoveReminderGroup()
            //            {
            //                GroupName = "Wife"
            //            }
            //        }
            //    }
            //};
            return new LoveReminder()
            {
                CurrentQuote = GetLoveQuote()
            };
        }
    }
}
