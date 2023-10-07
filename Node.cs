using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasklist_creator
{
    internal class Node
    {

        //entered tasks will be stored as a node

        public string Task { get; set; }
     

        public DateTime Date { get; set; }

        //constructor
        public Node(string task, DateTime date)
        {
            this.Task = task;
            this.Date = date;
        }


        //String representation of Node class

        public override string ToString()
        {
            return $"Task: {Task}\nDate: {Date}";

        }
    }
}
