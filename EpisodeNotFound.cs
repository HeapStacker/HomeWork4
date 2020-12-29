using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class TvException : Exception
    {
        public string Title { get; set; }
        public TvException() : base("Episode not found")
        {
            Title = "Tv Exception";
        }
    }
}
