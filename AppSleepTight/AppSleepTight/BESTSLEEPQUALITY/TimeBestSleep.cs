using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSleepTight.BESTSLEEPQUALITY
{
    public class TimeBestSleep
    {
        public int id { get; set; }

        public string Diary { get; set; }

        public string Quality { get; set; }

        public TimeBestSleep(BestSleep bestsleep)
        {
            this.id = bestsleep.id;
            this.Diary = bestsleep.DIARY;
            this.Quality = bestsleep.Quality;
            
        }

    }
}
