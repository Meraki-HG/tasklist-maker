using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasklist_creator { 


    //the data structure where each Node (task ) os going to be stored
    internal class dictionary
    {

      


        //storing the node as the value field in a dictionary

        public Dictionary<int, Node> tasks;
 
        public int Key;



        //paraneterless constructor

        //initialise an empty dictionary
        public dictionary()  
        {
            tasks = new Dictionary<int, Node>();
     
            Key = 0;
        }



  
        //Add Tasks 

        public void AddTask( string task)
        {
            Console.WriteLine("***Adding Tasks To Dictionary ***");

            DateTime date = DateTime.Now;  //variable for time

            //initialise a task node
            Node tsk = new Node(task, date);

            tasks.Add(Key, tsk);
            Key++;   //auto increases with every task added

            
        }


        

        
        //Remove Tasks

        public void RemoveTask(int key)
        {
            Console.WriteLine("***Removing word from the dictionary***");

            Tasks.Remove(key);
            Console.WriteLine();

        }

        //update tasks

        //check if the task needing an update exists in the dictionary - return null
        //




        //remove one task from one category and add it to another if exists

        //print success message

      



        //print all tasks

        //takes a dictionary (todo , doing or done) and prints out the content



        
    }
}
