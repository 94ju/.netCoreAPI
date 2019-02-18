using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    public class Manupulate
    {
   

        public static void getStringncheck(List<TodoItem> todoItem)
        {
            List<String> names = new List<string>();
            foreach (TodoItem todoitems in todoItem) {
                names.Add(todoitems.Name);
            }
            
            Console.WriteLine(todoItem);
            Console.WriteLine(names);
            //throw new NotImplementedException();
        }
    }
}

