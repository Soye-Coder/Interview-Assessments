using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using TodoApiApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApiApp.Controllers
{
    // The controller class responsible for handling Todo operations.
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoModels todo; // Reference to the ITodoModels service.

        // Constructor to inject ITodoModels service.
        public TodosController(ITodoModels models)
        {
            this.todo = models;
        }

        // GET: api/Todos
        [HttpGet]
        public List<TodoModels> Get()
        {
            // Get all Todos from the ITodoModels service and return the list.
            return todo.GetAllTodos();
        }

        // GET api/Todos/{id}
        [HttpGet("{id}")]
        public string Get(string id)
        {
            // Get a specific Todo by ID from the ITodoModels service.
            // Return the Todo's data if found, or "Not Found" otherwise.
            return todo.GetOneTodo(id) ?? "Not Found";
        }

        // POST api/Todos
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // Create a new TodoModel with a new unique ID and the provided data.
            TodoModels model = new TodoModels
            {
                Id = Guid.NewGuid().ToString(),
                Data = value
            };

            // Add the new Todo to the ITodoModels service.
            todo.PostTodo(model);
        }

        // PUT api/Todos/{id}
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            // Update the data of a Todo with the specified ID in the ITodoModels service.
            todo.UpdateTodo(id, value);
        }

        // DELETE api/Todos/{id}
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            // Delete a Todo with the specified ID from the ITodoModels service.
            todo.DeleteTodo(id);
        }
    }
}
