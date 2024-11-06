using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane
{
    public class Letishte
    {
        private string destinaciq;
        private int kod;
        private double chas;
        private double data;
        public string Destinaciq
        {
            get { return this.destinaciq; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Vuvedi grad");               
                this.destinaciq = value;
            }
        }
        public int Kod
        {
            get { return this.kod; }
            set { this.kod = value; }
        }
        public double Chas
        {
            get { return this.chas; }
            set 
            {
                this.chas = value; 
            }
        }
        public double  Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public Letishte(string destinaciq,int kod)
        {
            this.Destinaciq = destinaciq;
            this.Kod = kod;
        }
        public Letishte(string destinaciq,int kod,double chas,double data)
        {
            this.Destinaciq = destinaciq;
            this.Kod = kod;
            this.Chas = chas;
            this.Data = data;
        }
        public void Print()
        {            
            Console.WriteLine($"Destinaciq:{this.Destinaciq} Kod:{this.Kod} Chas:{this.Chas} Data:{this.Data}");
        }
        public override string ToString()
        {
            return $"Destinaciq:{this.Destinaciq} Kod:{this.Kod} Chas:{this.Chas} Data:{this.Data}";
        }
    }
}
