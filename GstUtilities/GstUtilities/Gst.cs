using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GstUtilities
{
    public class Gst
    {
        public double ProAmt { get; set; }

        public double GstPer { get; set; }


        public Gst(double proAmt, double gstPer)
        {
            this.ProAmt = proAmt;
            this.GstPer = gstPer;
        }

        public double CalculateGstAmt()
        {
            double GstAmt = this.ProAmt / 100 * this.GstPer;
            return GstAmt;
        }

        public double CalculateTotalProAmt()
        {
            double totalAmt = CalculateGstAmt() + this.ProAmt;
            return totalAmt;
        }
    }
}
