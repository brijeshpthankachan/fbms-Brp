using development_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace development_1
{


    internal class StudentMarkInformation
        {
        private string name;
        private int mark1, mark2;

        public StudentMarkInformation(string name, int mark1, int mark2)

        {
            this.name = name;
            this.mark1 = mark1;
            this.mark2 = mark2;
        }

        private int Total() => this.mark1 + this.mark2;

        public void GetData()
        {
            Console.WriteLine($"{this.name}  {this.mark1}  {this.mark2}  {this.Total()}");
        }
    }
   
}

