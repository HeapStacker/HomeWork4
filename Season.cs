using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork2
{
    class Season : IEnumerable<Episode>
    {
        private UInt16 season = 0;
        //private Episode[] episodes = { };
        public int Lenght = 0;
        private int totalViews = 0;
        private TimeSpan totalDuration = new TimeSpan(0, 0, 0);
        private List<Episode> listOfEpisodes = new List<Episode>();
        //public Episode this[int i]
        //{
        //    get { return episodes[i]; }
        //    set { episodes[i] = value; }
        //}
        public Episode this[int i]
        {
            get { return listOfEpisodes[i]; }
            set { listOfEpisodes[i] = value; }
        }
        //public Season(UInt16 season, Episode[] episodes)
        //{
        //    this.season = season;
        //    this.episodes = episodes;
        //    this.Lenght = episodes.Length;
        //    this.totalViews = GetTotalViews();
        //    this.totalDuration = GetTotalDuration();
        //}
        public Season(UInt16 season, List<Episode> listOfEpisodes)
        {
            this.season = season;
            this.listOfEpisodes = listOfEpisodes;
            //this.Lenght = episodes.Length;
            this.Lenght = listOfEpisodes.Count;
            this.totalViews = GetTotalViews();
            this.totalDuration = GetTotalDuration();
        }
        public Season(Season season)
        {
            this.season = season.season;
            this.Lenght = season.Lenght;
            this.totalViews = season.totalViews;
            this.totalDuration = season.totalDuration;
            this.listOfEpisodes = season.listOfEpisodes;
        }
        public override string ToString()
        {
            string eps = $"Season {season}\n";
            eps += "=================================================\n";
            foreach (Episode ep in listOfEpisodes)
            {
                eps += $"{ep.GetViewerCount()},{ep.getSum()},{ep.GetMaxView()},{ep.GetDescription().eNum},";
                eps += $"{ep.GetDescription().eTime},{ep.GetDescription().eName}\n";
            }
            eps += "Report:\n=================================================\n";
            eps += $"Total viewers: {GetTotalViews()}\nTotal duration: {totalDuration}\n";
            return eps;
        }
        public void addNewEpisode(Episode ep)
        {
            listOfEpisodes.Add(ep);
        }
        public void Remove(string epName)
        {
            if (listOfEpisodes.RemoveAll(e => { return e.GetDescription().eName == epName; }) == 0) throw new TvException();
        }
        private int GetTotalViews()
        {
            totalViews = 0;
            //foreach (Episode ep in episodes)
            //{
            //    totalViews += ep.GetViewerCount();
            //}
            foreach(Episode ep in listOfEpisodes)
            {
                totalViews += ep.GetViewerCount();
            }
            return totalViews;
        }
        private TimeSpan GetTotalDuration()
        {
            totalDuration = new TimeSpan();
            //foreach (Episode ep in episodes)
            //{
            //    totalDuration += ep.GetDescription().eTime;
            //}
            foreach (Episode ep in listOfEpisodes)
            {
                totalDuration += ep.GetDescription().eTime;
            }
            return totalDuration;
        }

        public IEnumerator<Episode> GetEnumerator()
        {
            return listOfEpisodes.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listOfEpisodes.GetEnumerator();
        }
    }
}
