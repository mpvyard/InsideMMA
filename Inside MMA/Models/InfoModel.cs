﻿namespace Inside_MMA.Models
{
    public class InfoModel
    {
        public string NameFile { set; get; }
        public string Tiker { set; get; }
        public string TimeSearch { set; get; }
        public InfoModel(string name, string tiker, string time)
        {
            NameFile = name;
            Tiker = tiker;
            TimeSearch = time;
        }
    }
}
