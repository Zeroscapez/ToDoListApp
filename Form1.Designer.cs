namespace ToDoListApp
{
    partial class Form1
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
            taskInput = new TextBox();
            addTaskBtn = new Button();
            taskList = new ListBox();
            deleteTaskBtn = new Button();
            completeTaskBtn = new Button();
            notesBox = new RichTextBox();
            Notes = new Label();
            SuspendLayout();
            // 
            // taskInput
            // 
            taskInput.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskInput.Location = new Point(12, 12);
            taskInput.Multiline = true;
            taskInput.Name = "taskInput";
            taskInput.Size = new Size(440, 109);
            taskInput.TabIndex = 0;
            // 
            // addTaskBtn
            // 
            addTaskBtn.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            addTaskBtn.Location = new Point(491, 12);
            addTaskBtn.Name = "addTaskBtn";
            addTaskBtn.Size = new Size(207, 109);
            addTaskBtn.TabIndex = 1;
            addTaskBtn.Text = "Add Task";
            addTaskBtn.UseVisualStyleBackColor = true;
            addTaskBtn.Click += addTaskBtn_Click;
            // 
            // taskList
            // 
            taskList.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskList.FormattingEnabled = true;
            taskList.ItemHeight = 20;
            taskList.Location = new Point(12, 138);
            taskList.Name = "taskList";
            taskList.Size = new Size(440, 284);
            taskList.TabIndex = 2;
            taskList.SelectedIndexChanged += TaskList_SelectedIndexChanged;
            // 
            // deleteTaskBtn
            // 
            deleteTaskBtn.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            deleteTaskBtn.Location = new Point(491, 318);
            deleteTaskBtn.Name = "deleteTaskBtn";
            deleteTaskBtn.Size = new Size(207, 109);
            deleteTaskBtn.TabIndex = 3;
            deleteTaskBtn.Text = "Delete Task";
            deleteTaskBtn.UseVisualStyleBackColor = true;
            deleteTaskBtn.Click += deleteTaskBtn_Click;
            // 
            // completeTaskBtn
            // 
            completeTaskBtn.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            completeTaskBtn.Location = new Point(491, 138);
            completeTaskBtn.Name = "completeTaskBtn";
            completeTaskBtn.Size = new Size(207, 109);
            completeTaskBtn.TabIndex = 4;
            completeTaskBtn.Text = "Complete Task";
            completeTaskBtn.UseVisualStyleBackColor = true;
            completeTaskBtn.Click += completeTaskBtn_Click;
            // 
            // notesBox
            // 
            notesBox.Location = new Point(12, 482);
            notesBox.Name = "notesBox";
            notesBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            notesBox.Size = new Size(440, 146);
            notesBox.TabIndex = 6;
            notesBox.Text = "";
            notesBox.TextChanged += NotesBox_TextChanged;
            // 
            // Notes
            // 
            Notes.AutoSize = true;
            Notes.Font = new Font("MS Reference Sans Serif", 20F);
            Notes.Location = new Point(12, 438);
            Notes.Name = "Notes";
            Notes.Size = new Size(92, 34);
            Notes.TabIndex = 7;
            Notes.Text = "Notes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 640);
            Controls.Add(Notes);
            Controls.Add(notesBox);
            Controls.Add(completeTaskBtn);
            Controls.Add(deleteTaskBtn);
            Controls.Add(taskList);
            Controls.Add(addTaskBtn);
            Controls.Add(taskInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox taskInput;
        private Button addTaskBtn;
        private ListBox taskList;
        private Button deleteTaskBtn;
        private Button completeTaskBtn;
        private RichTextBox notesBox;
        private Label Notes;
    }
}
