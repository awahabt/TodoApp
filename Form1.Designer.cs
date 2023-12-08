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
            titleText.Location = new Point(31, 107);
            titleText.Name = "titleText";
            titleText.Size = new Size(54, 24);
            titleText.TabIndex = 1;
            titleText.Text = "Title";
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 651);
            Controls.Add(titleText);
            Controls.Add(headerText);
            Name = "TodoForm";
            Text = "To Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerText;
        private Label titleText;
    }
}
