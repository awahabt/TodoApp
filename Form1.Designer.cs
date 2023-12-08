namespace TodoApp
{
    partial class TodoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerText = new Label();
            titleText = new Label();
            titleTextBox = new TextBox();
            descriptionText = new Label();
            descriptionTextBox = new TextBox();
            saveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            taskViewText = new Label();
            taskGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)taskGridView).BeginInit();
            SuspendLayout();
            // 
            // headerText
            // 
            headerText.BackColor = Color.Black;
            headerText.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerText.ForeColor = Color.White;
            headerText.Location = new Point(-1, 0);
            headerText.Name = "headerText";
            headerText.Size = new Size(977, 77);
            headerText.TabIndex = 0;
            headerText.Text = "To Do List";
            headerText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleText.Location = new Point(46, 103);
            titleText.Name = "titleText";
            titleText.Size = new Size(54, 24);
            titleText.TabIndex = 1;
            titleText.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.White;
            titleTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTextBox.Location = new Point(51, 134);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(630, 27);
            titleTextBox.TabIndex = 2;
            // 
            // descriptionText
            // 
            descriptionText.AutoSize = true;
            descriptionText.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionText.Location = new Point(46, 181);
            descriptionText.Name = "descriptionText";
            descriptionText.Size = new Size(128, 24);
            descriptionText.TabIndex = 3;
            descriptionText.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.White;
            descriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTextBox.Location = new Point(51, 212);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(872, 27);
            descriptionTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Black;
            saveButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(687, 132);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 31);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Black;
            editButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(768, 132);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 31);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Black;
            deleteButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(848, 132);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 31);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // taskViewText
            // 
            taskViewText.AutoSize = true;
            taskViewText.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskViewText.Location = new Point(51, 261);
            taskViewText.Name = "taskViewText";
            taskViewText.Size = new Size(154, 24);
            taskViewText.TabIndex = 8;
            taskViewText.Text = "Task View List";
            // 
            // taskGridView
            // 
            taskGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskGridView.BackgroundColor = Color.White;
            taskGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskGridView.Location = new Point(51, 292);
            taskGridView.Name = "taskGridView";
            taskGridView.Size = new Size(872, 360);
            taskGridView.TabIndex = 9;
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 698);
            Controls.Add(taskGridView);
            Controls.Add(taskViewText);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionText);
            Controls.Add(titleTextBox);
            Controls.Add(titleText);
            Controls.Add(headerText);
            Name = "TodoForm";
            Text = "To Do List";
            Load += TodoForm_Load;
            ((System.ComponentModel.ISupportInitialize)taskGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerText;
        private Label titleText;
        private TextBox titleTextBox;
        private Label descriptionText;
        private TextBox descriptionTextBox;
        private Button saveButton;
        private Button editButton;
        private Button deleteButton;
        private Label taskViewText;
        private DataGridView taskGridView;
    }
}
