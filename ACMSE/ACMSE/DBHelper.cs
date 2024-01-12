using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMSE
{
    public class DBHelper
    {
        public Demobase12037DB db;

        public DBHelper()
        {
            db = new Demobase12037DB("Orion");
        }

        ~DBHelper()
        {
            db.Close();
        }

        public List<Person> GetEmployeesList(int valueFrom, int valueTo)
        {
            var query = from c in db.PLists where (c.ID > valueFrom) && (c.ID < valueTo) select new Person(c.ID, c.Name, c.FirstName, c.MidName);
            return query.ToList();
        }

        //получение текущего местоположения сотрудника
        public string GetCurrentLocation(int selectedValue)
        {
            //получаем все события по СКУД по заданному сотруднику отсортированные по времени
            var q = from c in db.PLogData where (c.HozOrgan == selectedValue) && (c.Event == 32) orderby c.TimeVal select c;
            //если сотрудник не перемещался по СКУД, то его местоположение не определено
            if (q.ToList().Count == 0) return "";
            //если последним перемещением сотрудника был вход, то вернуть местоположение в которое он вошёл
            //иначе местополжение не определено
            if (q.ToList().Last().Mode == 1)
            {
                int? door = q.ToList().Last().DoorIndex;
                var qq = from c in db.AcessPoints where c.GIndex == door join loc in db.AccessZones on c.IndexZone1 equals loc.ID select new { Zone = loc.Name };
                return qq.ToList().First().Zone;
            }
            else return "";
        }

        internal List<Location> GetLocationsList()
        {
            var query = from c in db.AccessZones select new Location(c.ID, c.Name);
            return query.ToList();
        }

        internal List<Door> GetDoors()
        {
            var query = from c in db.AcessPoints select new Door(c.ID, c.Name, c.IndexZone1);
            return query.ToList();
        }
    }
}
