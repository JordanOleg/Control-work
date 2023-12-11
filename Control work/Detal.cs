using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_work
{
    public class Detal
    {
        public Detal() { }  
        public Detal(string name, string sort, DateTime dateTime, int quant, float cost) 
        {
            switch (sort)
            {
                case "I":
                case "i":
                case "1":
                    SortValue = Sort.I;
                    break;
                case "II":
                case "2":
                case "ii":
                    SortValue = Sort.II;
                    break;
                case "III":
                case "3":
                case "iii":
                    SortValue = Sort.III;
                    break;
                default:
                    break;
            }
            this.Name = name;
            this.DateTime = dateTime;
            this.Quant = quant;
            this.Cost = cost;
        }
        public Detal(string name, Sort sort, DateTime dateTime, int quant, float cost)
        {
            SortValue = sort;
            this.Name = name;
            this.DateTime = dateTime;
            this.Quant = quant;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public enum Sort { I, II, III }
        public Sort SortValue { get; set; }
        public DateTime DateTime { get; set; }
        public int Quant { get; set; }
        public float Cost { get; set; }
        public float Sum { get; private set; }
        public void SetSum()
        {
            Sum = Cost * Quant;
        }
    }
}
