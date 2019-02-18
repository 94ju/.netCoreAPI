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
            string stringName = string.Join(",", names);
            // string[] authorsList = stringName.Split(", ");

            stringName=String.Concat(stringName," This is th name list");
            todoItem[0].Name = stringName;
            //TodoItem todoitem = new TodoItem()
            //{
            //    Name = stringName 
                
            //};
            //transferData.PostTodoItem();
            //authorsList = authorsList[0] + ;
           // Console.WriteLine(authorsList);
            //Console.WriteLine(todoItem);
            //Console.WriteLine(names);
            //throw new NotImplementedException();
        }
    }
}

