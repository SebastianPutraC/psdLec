using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Repository
{
    public class ShipperRepo
    {
        static MydatabaseEntities2 db = Singleton.GetInstance();
        public static void save()
        {
            db.SaveChanges();
        }
        public static void InsertShipper(Shipper u)
        {
            db.Shippers.Add(u);
            db.SaveChanges();
        }
        public static void DeleteShipper(Shipper u)
        {
            db.Shippers.Remove(u);
            db.SaveChanges();
        }
        public static List<Shipper> GetShipper()
        {
            return (from Shipper in db.Shippers select Shipper).ToList();
        }
        public static Shipper GetShipperByName(string name)
        {
            Shipper shipper = (from s in db.Shippers where s.shipper_name.Equals(name) select s).FirstOrDefault();
            return shipper;
        }
        public static Shipper GetShipperByID(int id)
        {
            Shipper shipper = (from s in db.Shippers where s.Shipper_id.Equals(id) select s).FirstOrDefault();
            return shipper;
        }
    }
}