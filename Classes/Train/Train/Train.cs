using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Train
    {
        private int id;
        private string station;
        private int train_km;
        private int engine_km;
        private int maintenance;

        // Constructor
        public Train(int id, string station)
        {
            this.id = id;
            this.station = station;
            this.train_km = 0;
            this.engine_km = 0;
            this.maintenance = 0;
        }

        // פעולה קובעת מיקום
        public void SetStation(string s)
        {
            this.station = s;
        }

        // פעולה מאחזרת מיקום
        public string GetStation()
        {
            return this.station;
        }

        // פעולה מאחזרת מספר רכבת
        public int GetID()
        {
            return this.id;
        }

        // פעולה מאחזרת קילומטראז
        public int GetTotalKm()
        {
            return this.train_km;
        }

        // פעולה מאחזרת כמה קילומטר עבר המנוע מאז החלפה אחרונה
        public int GetEngineKm()
        {
            return this.engine_km;
        }

        // פעולה מאחזרת מספר טיפולים שעברה הרכבת\
        public int GetMaintenanceNum()
        {
            return this.maintenance;
        }

        // פעולת הוספת ק"מ לרכבת
        public void AddKm(int kmToAdd)
        {
            this.train_km += kmToAdd;
            this.engine_km += kmToAdd;
        }

        // פעולת בדיקה האם צריך טיפול
        public bool MaintenanceNeeded()
        {
            return this.engine_km > 100000;
        }

        // פעולה מעדכנת תכונות לאחר טיפול
        public int DoMaintenance()
        {
            int engineKmSave = this.engine_km;
            this.engine_km = 0;
            this.maintenance++;

            return engineKmSave;
        }

        // פעולה מתארת ToString
        public override string ToString()
        {
            return $"Train ID: {this.id}, Total Km = {this.train_km}, engine Km = {this.engine_km}, engine changed: {this.maintenance} times.";
        }
    }
}
