using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managent_Addlication
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 0;
        private string name = string.Empty; // ""
        private string alldata = string.Empty;

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa + "\r\n";

            if (this.max < gpa)
            {
                this.max = gpa;
            }

            if (this.min <= this.max)
            {
                this.min = gpa;
            }

            public double getMax()
            {
                return this.max;
            }
            public double getMin()
            {
                return this.min;
            }
            public string getAlldata()
            {
                return alldata;
            }
        }

    }
}