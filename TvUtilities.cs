using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Compareable : IComparer<Episode>
    {
        public int Compare(Episode a, Episode b)
        {
            return b.suma.CompareTo(a.suma);
        }
    }
    static class TvUtilities
    {
        static public Episode Parse(string epDesc)
        {
            string[] subStrs = epDesc.Split('|');
            int a = int.Parse(subStrs[0]);
            double b = double.Parse(subStrs[1]);
            double c = double.Parse(subStrs[2]);
            int d = int.Parse(subStrs[3]);
            TimeSpan e = TimeSpan.Parse(subStrs[4]);
            string f = subStrs[5];
            return new Episode(a, b, c, d, e, f);
        }
        static public Episode[] Sort(Episode[] eps)
        {
            List<Episode> sortedList = new List<Episode>();
            sortedList.AddRange(eps);
            Compareable cc = new Compareable();
            sortedList.Sort(cc);
            for (UInt16 i = 0; i < eps.Length; i++)
            {
                eps[i] = sortedList[i];
            }
            return eps;
        }
        //static public Episode[] LoadEpisodesFromFile(string fileName)
        //{
        //    string[] episodes = System.IO.File.ReadAllLines(fileName);
        //    Episode[] episodeArr = new Episode[episodes.Length];

        //    int viewerCount = 0, d = 0;
        //    double suma = 0, maxView = 0;
        //    TimeSpan e = new TimeSpan(0);
        //    string name = "Unknown";

        //    for (int i = 0; i < episodes.Length; i++)
        //    {
        //        string[] subStrs = episodes[i].Split('|');
        //        viewerCount = int.Parse(subStrs[0]);
        //        suma = double.Parse(subStrs[1]);
        //        maxView = double.Parse(subStrs[2]);
        //        d = int.Parse(subStrs[3]);
        //        e = TimeSpan.Parse(subStrs[4]);
        //        Episode tempEp = new Episode(viewerCount, suma, maxView, d, e, subStrs[5]);
        //        episodeArr[i] = tempEp;
        //    }
        //    return episodeArr;
        //}
        static public List<Episode> LoadEpisodesFromFile(string fileName)
        {
            string[] episodes = System.IO.File.ReadAllLines(fileName);
            List<Episode> episodeLIst = new List<Episode>();

            int viewerCount = 0, d = 0;
            double suma = 0, maxView = 0;
            TimeSpan e = new TimeSpan(0);

            for (int i = 0; i < episodes.Length; i++)
            {
                string[] subStrs = episodes[i].Split('|');
                viewerCount = int.Parse(subStrs[0]);
                suma = double.Parse(subStrs[1]);
                maxView = double.Parse(subStrs[2]);
                d = int.Parse(subStrs[3]);
                e = TimeSpan.Parse(subStrs[4]);
                Episode tempEp = new Episode(viewerCount, suma, maxView, d, e, subStrs[5]);
                episodeLIst.Add(tempEp);
            }
            return episodeLIst;
        }
        public static int GenerateRandomScore()
        {
            Random tempRand = new Random();
            return tempRand.Next(0, 1001); //Just because of simplicity
        }
    }
}
