using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 

namespace WFP_8498376
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMetricA_Click(object sender, EventArgs e)
        {

            String strURL = GetJSONURL();
            string json = (new WebClient()).DownloadString(strURL);
            List<Rootobject> lstRootObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rootobject>>(json);
            List<Country> lstCountryObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(json);
            List<Rootobject> items = JsonConvert.DeserializeObject<List<Rootobject>>(json);
            List<Class1> items1 = JsonConvert.DeserializeObject<List<Class1>>(json);

            int count = lstRootObject.Count;
            int i = 0;
            long lngPopulation = 0;
            long lngfcsPeople = 0;
            long lngrcsiPeople = 0;
            long lngmarketAccessPeople = 0;
            double[] arrFCSPrevalance = new double[count + 1];

            foreach (var objCountry in items1)
            {
                lngPopulation = lngPopulation + objCountry.region.population;
                lngfcsPeople = lngfcsPeople + objCountry.metrics.fcs.people;
                lngrcsiPeople = lngrcsiPeople + objCountry.metrics.rcsi.people;
                lngmarketAccessPeople = lngmarketAccessPeople + objCountry.metrics.marketAccess.people;
                arrFCSPrevalance[i] = objCountry.metrics.fcs.prevalence;
                i = i + 1;
            }
            Response.Write("<br>Average Population:" + lngPopulation / (double)count);
            Response.Write("<br>Average fcs People:" + lngfcsPeople / (double)count);
            Response.Write("<br>Average rcsi People:" + lngrcsiPeople / (double)count);
            Response.Write("<br>Average marketAccess People:" + lngmarketAccessPeople / (double)count);
            Response.Write("<br>Variance FCS Prevalance:" + Variance(arrFCSPrevalance));
        }

              
            private string GetJSONURL()
        {
            DateTime startDate = calStartDate.SelectedDate;
            DateTime endDate = calEndDate.SelectedDate;

            String strURL = System.Configuration.ConfigurationManager.AppSettings["JSONURL"];
            strURL = strURL + ddlCountry.SelectedItem.Value + "/region?date_start=" + startDate.ToString("yyyy-MM-dd") + "&date_end=" + endDate.ToString("yyyy-MM-dd");


            return strURL;
         }

        public static double Variance(double[] x)
        {
            if (x.Length == 0)
                return 0;
            double sumX = 0;
            double sumXsquared = 0;
            double varianceX = 0;
            int dataLength = x.Length;


            for (int i = 0; i < dataLength; i++)
            {
                sumX += x[i];
                sumXsquared += x[i] * x[i];
            }

            varianceX = (sumXsquared / dataLength) - ((sumX / dataLength) * (sumX / dataLength));
            return varianceX;
        }

        protected void btnMetricB_Click(object sender, EventArgs e)
        {

        }

        protected void btnPlotMetricB_Click(object sender, EventArgs e)
        {

        }
    }
}