# Todo McKinsey Assessment

This project is a simple Todo API built for the McKinsey Assessment. It allows users to manage their tasks through basic CRUD operations (Create, Read, Update, Delete). The API is designed to handle Todo items, each having an ID and a data item representing the todo.

## Technologies Used

- **C#:** The backend of the application is written in C#.
- **ASP.NET Core:** The API framework used for building robust APIs.
- **Swagger:** API documentation tool to easily visualize and interact with the API's resources.

## API Endpoints

- **GET /api/Todos:**  
  Get a list of all Todo items.

- **GET /api/Todos/{id}:**  
  Get a specific Todo item by its ID.

- **POST /api/Todos:**  
  Create a new Todo item. Send a JSON object with the `data` property.

- **PUT /api/Todos/{id}:**  
  Update an existing Todo item by its ID. Send a JSON object with the `data` property.

- **DELETE /api/Todos/{id}:**  
  Delete a Todo item by its ID.

## Usage

Here's how you can interact with the API endpoints:

- **Get all Todo items:**  
  `GET /api/Todos`

- **Get a specific Todo item:**  
  `GET /api/Todos/{id}`

- **Create a new Todo item:**  
  `POST /api/Todos` (Send JSON object with `data` property)

- **Update a Todo item:**  
  `PUT /api/Todos/{id}` (Send JSON object with `data` property)

- **Delete a Todo item:**  
  `DELETE /api/Todos/{id}`
