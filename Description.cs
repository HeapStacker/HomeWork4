using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HomeWork2
{
    class Description : Attribute
    {
        public string eName;
        public int eNum;
        public TimeSpan eTime;
        public Description()
        {

        }
        public override string ToString()  //Overidamo base Object class po našem zahtjevu
        {
            string returnString = $"{eNum}, {eTime}, {eName}";
            return returnString; 
        }
        public Description(int epNum, TimeSpan epTime, string name)
        {
            this.eNum = epNum;
            this.eTime = epTime;
            this.eName = name;
        }
    }
}
