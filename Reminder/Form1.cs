using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Reminder.modules;

namespace Reminder
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
            /*
            string toDoText = toDoThing.Text;
            string toDoInfo = toDoDetail.ToString();
            string dateSelect = datePicker.Value.ToString("yyyy-MM-dd");
            Submit submit = new Submit();
            submit.updateList(dateSelect, toDoText, toDoInfo, toDoList);
            */
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string toDoText = toDoThing.Text;
            string toDoInfo = toDoDetail.Text;
            if (String.IsNullOrEmpty(toDoText))
            {
                log.Text = "[ERROR] NO INPUT!";
            }
            else
            {
                log.Text = "Successfully add to database";
                //toDoList.Items.Add(toDoText);
                string dateSelect = datePicker.Value.ToString("yyyy-MM-dd");
                Submit submit = new Submit();
                dateLabel.Text = dateSelect;
                submit.updateList(dateSelect, toDoText, toDoInfo, toDoList);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string dateSelect = datePicker.Value.ToString("yyyy-MM-dd");
            dateLabel.Text = dateSelect;
            Search search = new Search();
            search.setSearchResult(dateSelect, toDoList);
            detailLabel.Text = "";
        }

        private void toDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search search = new Search();
            search.setSearchResultInfo(dateLabel.Text, toDoList.Text, detailLabel);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            if(toDoList.Text != "")
            {
                delete.deleteAndUpdate(dateLabel.Text, toDoList.Text, toDoList);
                detailLabel.Text = "";
            }
        }
    }
}
