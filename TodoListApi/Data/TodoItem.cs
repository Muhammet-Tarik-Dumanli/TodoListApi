using System.ComponentModel.DataAnnotations;

namespace TodoListApi.Data
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
