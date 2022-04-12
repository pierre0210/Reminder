using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Reminder.modules
{
    public class Delete
    {
        public void deleteAndUpdate(string date, string deltitle, ListBox list)
        {
            Database database = new Database();
            database.delToDo(deltitle, date);
            list.Items.Clear();
            string[] title = database.getDateTitle(date);
            foreach (string titleItem in title)
            {
                list.Items.Add(titleItem);
            }
        }
    }
}
