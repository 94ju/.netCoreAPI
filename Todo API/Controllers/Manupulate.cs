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
            //TodoController transferData = new TodoController();
            List<String> names = new List<string>();
            foreach (TodoItem todoitems in todoItem) {
                names.Add(todoitems.Name);
            }
           string stringName = string.Join(",", names[0]);
            string stringName2 = string.Join(",", names[1]);
            //  names[0] = names[0].Split(", ");

            List<int[]> nameList = new List<int[]>();
            List<string> diff;
            IEnumerable<string> set1 = stringName.Split(',').Distinct();
            IEnumerable<string> set2 = stringName2.Split(',').Distinct();

            if (set2.Count() > set1.Count())
            {
                diff = set2.Except(set1).ToList();
            }
            else
            {
                diff = set1.Except(set2).ToList();
            }
          
            todoItem[1].Name = string.Join(",", diff);
         
        }
    }
}

