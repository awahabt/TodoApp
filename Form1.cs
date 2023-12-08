using System.Data;

namespace TodoApp
{
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void TodoForm_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            taskGridView.DataSource = todoList;

        }

        private void clearTaskButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            titleTextBox.Text = todoList.Rows[taskGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[taskGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[taskGridView.CurrentCell.RowIndex].Delete();
            }
            catch
            {
                Console.WriteLine("Error: ");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[taskGridView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[taskGridView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;

            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
            }

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }

        
    }
}
