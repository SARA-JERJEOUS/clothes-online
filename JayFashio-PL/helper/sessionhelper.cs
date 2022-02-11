using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JayFashio_PL.helper
{
    public class sessionhelper
    {
        public static bool isuser
        {
            get
            {
                if (HttpContext.Current.Session["Isuser"] == null)
                    return false;
                return (bool)HttpContext.Current.Session["Isuser"];
            }
            set
            {
                HttpContext.Current.Session["Isuser"] = value;
            }
        }
    }
}