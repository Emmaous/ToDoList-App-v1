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
    }
}
