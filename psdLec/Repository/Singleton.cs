using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Repository
{
    public class Singleton
    {
        private static MydatabaseEntities2 db = null;
        public static MydatabaseEntities2 GetInstance()
        {
            if (db == null)
            {
                db = new MydatabaseEntities2();
            }
            return db;
        }
    }
}