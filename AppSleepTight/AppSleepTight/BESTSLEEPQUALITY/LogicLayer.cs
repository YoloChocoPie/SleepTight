using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSleepTight.BESTSLEEPQUALITY
{
    public class LogicLayer
    {
        public BestSleep[] GetData()
        {
            var db = new BestSleepEntities();
            return db.BestSleeps.ToArray();
        }

        public BestSleep GetData(int id) 
        {
            var db = new BestSleepEntities();
            return db.BestSleeps.Find(id);
        }

        public void CreateData(string diary, string quality)
        {
            var bestsleep = new BestSleep();
            bestsleep.DIARY = diary;
            
            bestsleep.Quality = quality;
            

            var db = new BestSleepEntities();
            db.BestSleeps.Add(bestsleep);
            db.SaveChanges();
        }

        public void DeleteData(int id)
        {
            var db = new BestSleepEntities();
            var bestsleep = db.BestSleeps.Find(id);

            db.BestSleeps.Remove(bestsleep);
            db.SaveChanges();
        }
    }
}
