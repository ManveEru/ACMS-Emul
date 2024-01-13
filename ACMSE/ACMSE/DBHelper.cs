using LinqToDB;
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
            
        }

        public List<Person> GetEmployeesList(int valueFrom, int valueTo)
        {
            var query = from c in db.PLists where (c.ID > valueFrom) && (c.ID <= valueTo) select new Person(c.ID, c.FirstName, c.Name, c.MidName);
            return query.ToList();
        }

        //получение текущего местоположения сотрудника
        public CurrentLocation GetCurrentLocation(int selectedValue)
        {
            CurrentLocation result = new CurrentLocation();
            //получаем все события по СКУД по заданному сотруднику отсортированные по времени
            var q = from c in db.PLogData where (c.HozOrgan == selectedValue) && (c.Event == 32) orderby c.TimeVal select c;
            //если сотрудник не перемещался по СКУД, то его местоположение не определено
            if (q.ToList().Count == 0) return result;
            //если последним перемещением сотрудника был вход, то вернуть местоположение в которое он вошёл
            //иначе местополжение не определено
            if (q.ToList().Last().Mode == 1)
            {
                result.Door = (int)q.ToList().Last().DoorIndex;
                var qq = from c in db.AcessPoints where c.GIndex == result.Door join loc in db.AccessZones on c.IndexZone1 equals loc.ID select new { Zone = loc.Name };
                result.Name = qq.ToList().First().Zone;
            }
            return result;
        }

        internal List<Location> GetLocationsList()
        {
            var query = from c in db.AccessZones select new Location(c.ID, c.Name);
            return query.ToList();
        }

        internal List<Door> GetDoors()
        {
            var query = from c in db.AcessPoints select new Door(c.GIndex, c.Name, c.IndexZone1);
            return query.ToList();
        }

        internal void Exit(int EmployeId, int door, int passMode)
        {
            var record = new PLogData()
            {
                TimeVal = DateTime.Now,
                NumCom = 39629,
                IDComp = 1,
                Par1 = 213,
                Par2 = 207,
                Par3 = 178,
                Par4 = 229,
                Event = 32,
                IndexKey = null,
                RazdIndex = 0,
                HozOrgan = EmployeId,
                HozGuest = 1,
                Remark = "10: Вход   Дверь 10,   Считыватель 1, Прибор  10",
                DoorIndex = door,
                Mode = passMode,
                DeviceTime = DateTime.Now,
                VEvent = 0,
                ZReserv = 1657,
                ZoneIndex = 14,
                ReaderIndex = 113,
                Sign = 0,
                TpRzdIndex = 0,
                TpPar4 = null,
                IndexZone = 113,
                TpIndex = 8,
                GUID = Guid.NewGuid(),
                IdComment = null,
                ExternalEventId = 0,
                StrAddr = "\\Линия:1\\C2000-Ethernet:192.168.8.12:40000\\C2000-2:10\\Считыватель:1"
            };
            db.Insert(record);
        }
    }
}
