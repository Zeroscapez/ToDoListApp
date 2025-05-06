namespace ToDoListApp
{
    public class TaskItem
    {
        public TaskItem() { }

        public TaskItem(string description)
            : this(description, string.Empty) { }

        public TaskItem(string description, string notes)
        {
            Description = description;
            IsCompleted = false;
            Notes = notes;
        }

        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; } = string.Empty;

        public override string ToString()
            => IsCompleted
               ? "[Done] " + Description
               : Description;
    }


}