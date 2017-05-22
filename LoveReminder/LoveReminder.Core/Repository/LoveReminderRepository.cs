using LoveReminder.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveReminder.Core.Repository
{
    public class LoveReminderRepository
    {



        /* QuoteText could possibly have many quotes structured like:
         * 
         * QuoteText = String.Format("You're the best {0} EVER!", GroupType)
         * 
         * 
         * 
         * 
         * 
         */
        private static List<LoveReminderHistory> loveReminderHistory = new List<LoveReminderHistory>()
        {
            new LoveReminderHistory()
            {
                LoveReminders = new List<Models.LoveReminder>()
                {
                    new Models.LoveReminder()
                    {
                        CurrentQuote = new LoveQuote()
                        {
                            QuoteText = "Your family loves you!",
                            QuoteAuthor = "Jacob Barnes",
                            QuoteID = 1,
                            LoveReminderGroups = new List<LoveReminderGroup>()
                            {
                                new LoveReminderGroup()
                                {
                                    GroupName = "Wife"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Husband"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Grand-Mother"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Grand-Father"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Son"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Daughter"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Cousin"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Aunt"
                                },
                                new LoveReminderGroup()
                                {
                                    GroupName = "Uncle"
                                }
                            }
                        },
                        ImagePath = "SomePath",
                        TimeReminded = DateTime.Now,
                        SentBy = "Husband"
                    },
                    new Models.LoveReminder()
                    {
                        CurrentQuote = new LoveQuote()
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
                        },
                        ImagePath = "SomePath",
                        TimeReminded = DateTime.Now.AddDays(-2),
                        SentBy = "Husband"
                    },
                    new Models.LoveReminder()
                    {
                        CurrentQuote = new LoveQuote()
                        {
                            QuoteText = "#1 Husband!",
                            QuoteAuthor = "Jacob Barnes",
                            QuoteID = 2,
                            LoveReminderGroups = new List<LoveReminderGroup>()
                            {
                                  new LoveReminderGroup()
                                  {
                                      GroupName = "Husband"
                                  }
                            }
                        },
                        ImagePath = "SomePath",
                        TimeReminded = DateTime.Now.AddDays(-2),
                        SentBy = "Husband"
                    }
                }
            }
        };
    }
}
