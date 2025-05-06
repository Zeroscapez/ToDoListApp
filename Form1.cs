namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        private readonly TaskManager _taskManager = new TaskManager();
        private readonly string _dataFile;
        private int index;
        public Form1()
        {
            InitializeComponent();

            taskList.SelectedIndexChanged += TaskList_SelectedIndexChanged;
            notesBox.TextChanged += NotesBox_TextChanged;

            taskInput.Enter += taskInput_Enter;


            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var folder = Path.Combine(appData, "ToDoListApp");
            Directory.CreateDirectory(folder);
            _dataFile = Path.Combine(folder, "tasks.json");

            try
            {
                _taskManager.Load(_dataFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
             $" Failed to load saved tasks:\n{ex.Message}",
             "Load Error",
             MessageBoxButtons.OK,
             MessageBoxIcon.Warning
             );

            }

            RefreshTaskList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            string desc = taskInput.Text;
            string notes = notesBox.Text;


            _taskManager.Add(desc, notes);


            taskInput.Clear();
            notesBox.Clear();

            RefreshTaskList();

            taskList.SelectedIndex = _taskManager.Tasks.Count - 1; // Select the newly added task
        }

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            var selected = taskList.SelectedItem as TaskItem;
            _taskManager.Remove(selected);
            RefreshTaskList();
        }

        private void completeTaskBtn_Click(object sender, EventArgs e)
        {
            var selected = taskList.SelectedItem as TaskItem;
            _taskManager.Complete(selected);
            RefreshTaskList();
        }


        private void RefreshTaskList()
        {
            // Re-bind ListBox to show current tasks
            taskList.DataSource = null;
            taskList.DataSource = _taskManager.Tasks;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // save with error handling
            try
            {
                _taskManager.Save(_dataFile);
            }
            catch (Exception ex)
            {
                // Let user decide whether to cancel closing
                var result = MessageBox.Show(
                    $" Failed to save tasks:\n{ex.Message}\n\nClose anyway?",
                    "Save Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = taskList.SelectedItem as TaskItem;
            if (selected != null)
            {
                // Display notes in the RichTextBox when a task is selected
                notesBox.Text = selected.Notes;
            }
            else
            {
                // Clear the RichTextBox if no task is selected
                notesBox.Clear();
            }
        }

        private void NotesBox_TextChanged(object sender, EventArgs e)
        {
            var selected = taskList.SelectedItem as TaskItem;
            if (selected != null)
            {
                // Update the notes of the selected task
                selected.Notes = notesBox.Text;
            }
        }

        private void taskInput_Enter(object sender, EventArgs e)
    => PrepareForNewEntry();




        /// <summary>
        /// If a task is selected, clear that selection & input fields
        /// so the user can start typing a brand-new task/note.
        /// </summary>
        private void PrepareForNewEntry()
        {
            if (taskList.SelectedIndex != -1)
            {
                taskList.ClearSelected();
                taskInput.Clear();
                notesBox.Clear();
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
