﻿using System;
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
            var db = new BestSleepEntities4();
            return db.BestSleeps.ToArray();
        }

        public BestSleep GetData(int id) 
        {
            var db = new BestSleepEntities4();
            return db.BestSleeps.Find(id);
        }

        public void CreateData(string country, string quality)
        {
            var bestsleep = new BestSleep();
            bestsleep.Country = country;
            
            bestsleep.Quality = quality;
            

            var db = new BestSleepEntities4();
            db.BestSleeps.Add(bestsleep);
            db.SaveChanges();
        }
        public void UpdateData(string country, string quality, int country_id)
        {
            var db = new BestSleepEntities4();
            var bestsleep = db.BestSleeps.Find(country_id);

            bestsleep.Country = country;
            bestsleep.id = country_id;
            bestsleep.Quality = quality;
            //

            db.Entry(bestsleep).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteData(int id)
        {
            var db = new BestSleepEntities4();
            var bestsleep = db.BestSleeps.Find(id);

            db.BestSleeps.Remove(bestsleep);
            db.SaveChanges();
        }
    }
}
