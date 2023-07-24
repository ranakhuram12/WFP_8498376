using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WFP_8498376
{
    public class Rootobject
    {
        public Class1 Property1 { get; set; }
    }

    public class Class1
    {
        public Country country { get; set; }
        public Region region { get; set; }
        public string _date { get; set; }
        public string dataType { get; set; }
        public Metrics metrics { get; set; }
    }

    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string iso3 { get; set; }
        public string iso2 { get; set; }
    }

    public class Region
    {
        public int id { get; set; }
        public string name { get; set; }
        public int population { get; set; }
    }

    public class Metrics
    {
        public Fcs fcs { get; set; }
        public Rcsi rcsi { get; set; }
        public Marketaccess marketAccess { get; set; }
    }

    public class Fcs
    {
        public int people { get; set; }
        public float prevalence { get; set; }
    }

    public class Rcsi
    {
        public int people { get; set; }
        public float prevalence { get; set; }
    }

    public class Marketaccess
    {
        public int people { get; set; }
        public float prevalence { get; set; }
    }

}