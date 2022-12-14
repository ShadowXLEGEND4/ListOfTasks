using System.ComponentModel.DataAnnotations;

namespace ListOfTasks.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string TaskTitle { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DeadLine { get; set; }
        public string TaskDesc { get; set; }
    }
}
