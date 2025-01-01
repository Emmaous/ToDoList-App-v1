using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_App_v1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        //declaring Datatable that will display to the data grid view
        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoList_Load(object sender, EventArgs e)
        {
            //creating columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //point the data grid view to data source
            myListAppView.DataSource = todoList;
        }

        //function to clear text boxes when New Button is clicked
        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";

        }

        //function to edit task when Edit Button is clicked
        private void editTaskBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;

            //Fill text fields with data from the table
            titleTextBox.Text = todoList.Rows[myListAppView.CurrentCell.RowIndex].ItemArray[0].ToString();

            descriptionTextBox.Text = todoList.Rows[myListAppView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        //function to delete a Task when Delete Button is clicked
        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            //catch any errors that may occur
            try
            {
                //Delete current row selected
                todoList.Rows[myListAppView.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex)
            {
                //return message detailing error
                Console.WriteLine("Error:" + ex);
            }
        }

        private void saveTaskBtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                //if changing an already existing Task 
                todoList.Rows[myListAppView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[myListAppView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;

            }
            else
            {
                //Adds the Title and Description  entered to the Data Table
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);

            }

            //Clear Text fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }
    }
}
