using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Reminder.modules
{
    public class Search
    {
        public void setSearchResult(string date, ListBox list)
        {
            list.Items.Clear();
            Database database = new Database();
            string[] title = database.getDateTitle(date);
            foreach (string titleItem in title)
            {
                list.Items.Add(titleItem);
            }
        }
        public void setSearchResultInfo(string date, string title, Label label)
        {
            Database database = new Database();
            string info = database.getDateInfo(title, date);
            label.Text = info;
        }
    }
}
