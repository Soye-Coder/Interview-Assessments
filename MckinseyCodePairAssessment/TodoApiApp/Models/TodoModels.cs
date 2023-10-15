namespace TodoApiApp.Models
{
    // Class implementing the ITodoModels interface.
    public class TodoModels : ITodoModels
    {
        public string Id { get; set; } // Property to store Todo ID.
        public string Data { get; set; } // Property to store Todo data.

        // Static list to store Todo items.
        static List<TodoModels> TodoList = new List<TodoModels>();

        // Method to add a new Todo to the list.
        public void PostTodo(TodoModels todo)
        {
            TodoList.Add(todo);
        }

        // Method to get all Todos from the list.
        public List<TodoModels> GetAllTodos()
        {
            return TodoList;
        }

        // Method to get a specific Todo's data by ID.
        public string GetOneTodo(string id)
        {
            var result = TodoList.Find(x => x.Id == id);
            return result.Data;
        }

        // Method to update a Todo's data by ID.
        public void UpdateTodo(string id, string data)
        {
            var result = TodoList.Find(x => x.Id == id);
            result.Data = data;
        }

        // Method to delete a Todo by ID.
        public void DeleteTodo(string id)
        {
            var result = TodoList.RemoveAll(x => x.Id == id);
        }
    }

}
