using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PizzaHut
{
    public class Table
    {
        public Table(int id, string name, int status)
        {
            this.Id = id;
            this.name = name;
            this.status = status;
        }
        private int id;
        private int status;
        private string name;

        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
    }
}
