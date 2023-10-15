namespace TodoApiApp.Models
{
    // Interface defining the contract for TodoModels.
    public interface ITodoModels
    {
        string Data { get; set; } // Property to store Todo data.
        string Id { get; set; } // Property to store Todo ID.
        public void PostTodo(TodoModels todo); // Method to add a new Todo.
        public List<TodoModels> GetAllTodos(); // Method to get all Todos.
        public string GetOneTodo(string id); // Method to get a specific Todo by ID.
        public void UpdateTodo(string id, string data); // Method to update a Todo's data.
        public void DeleteTodo(string id); // Method to delete a Todo.
    }
}