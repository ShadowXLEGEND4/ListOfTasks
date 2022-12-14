namespace ListOfTasks.Models
{
    public class TaskListModel
    {
        public int ListId { get; set; }
        public int UserId { get; set; }
        public string TaskTitle { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
