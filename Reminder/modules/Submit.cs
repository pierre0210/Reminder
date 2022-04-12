using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Reminder.modules
{
    public class Submit
    {
        public void updateList(string dateSelect, string toDoText, string toDoInfo, ListBox list)
        {
            list.Items.Clear();
            Database database = new Database();
            database.createDatabase();
            database.addToDo(dateSelect, toDoText, toDoInfo);
            string[] title = database.getDateTitle(dateSelect);
            foreach(string titleItem in title)
            {
                list.Items.Add(titleItem);
            }
        }
    }
}
