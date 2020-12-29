using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork2
{
    class Episode
    {
        private List<double> views = new List<double>();
        private int viewerCount = 0;
        public double suma = 0;
        private double maxView = 0;
        private double avgView = 0;
        private Description thisEpDesc = null;
        public Episode()
        {

        }
        public Episode(int a, double b, double c)
        {
            viewerCount = a;
            suma = b;
            avgView = b / a;
            maxView = c;
        }
        public Episode(int a, double b, double c, Description desc)
        {
            viewerCount = a;
            suma = b;
            avgView = b / a;
            maxView = c;
            thisEpDesc = desc;
        }
        public Episode(int a, double b, double c, int d, TimeSpan e, string f)
        {
            viewerCount = a;
            suma = b;
            avgView = b / a;
            maxView = c;
            thisEpDesc = new Description(d, e, f);
        }
        public override string ToString()
        {
            string returnString = $"{viewerCount}, {suma}, {maxView}, ";
            string returnString1 = $"{thisEpDesc.eNum}, {thisEpDesc.eTime}, {thisEpDesc.eName}";
            return returnString + returnString1;
        }
        public void AddView(double val)
        {
            viewerCount++;
            views.Add(val);
            avgView = views.Average();
            if (val > maxView)
                maxView = val;
        }
        public double GetAverageScore()
        {
            if (views.Count == 0)
                return avgView;
            else
                return views.Average();
        }
        public int GetViewerCount()
        {
            return viewerCount;
        }
        public double getSum()
        {
            return suma;
        }
        public double GetMaxView()
        {
            return maxView;
        }
        public Description GetDescription()
        {
            return thisEpDesc;
        }
        public double GetMaxScore()
        {
            maxView = views.Max();
            return maxView;
        }
    }
}
