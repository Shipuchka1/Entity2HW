using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity2HW
{
    class Program
    {
        public static Model1 db = new Model1();
        static void Main(string[] args)
        {
            //Task2();
            //Task3();
            Task4();
        }

       public static void Task2()
        {
            var query = db.newEquipment.Select(s => new
            {
                s.strSerialNo,
                s.strManufYear,
                s.TablesManufacturer.strName
            }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item.strName + " "+item.strManufYear+" "+item.strSerialNo);
            }
        }

        public static void Task3()
        {
            var query = db.newEquipment.Include(x=>x.TablesModel).Select(s => new
            {
                s.strSerialNo,
                s.strManufYear,
                s.TablesManufacturer.strName
            }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item.strName + " " + item.strManufYear + " " + item.strSerialNo);
            }
        }

        public static void Task4()
        {
            var query = db.TablesManufacturer.FirstOrDefault(w => w.intManufacturerID == 2);

            db.Entry(query).Collection(Col => Col.newEq).Load();

            foreach (var item in query.newEq)
            {
                Console.WriteLine(item.strSerialNo);
            }
        }
    }
}
