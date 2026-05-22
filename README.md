# Movie Catalog RESTful API

## Project Overview

The Movie Catalog RESTful API is a web-based application developed using ASP.NET Core Web API. The project demonstrates the implementation of RESTful services for managing movies and directors. It supports CRUD operations, association routing, attribute routing, API testing using Postman, and HTTP traffic debugging using Fiddler.

The API allows users to:
- Create movies and directors
- Retrieve movie and director details
- Update movie information
- Delete movies
- Retrieve movies by a specific director
- Test API endpoints using Swagger and Postman
- Monitor and inspect HTTP requests using Fiddler

---

# Features

## Movie Management
- Get all movies
- Get movie by ID
- Add a new movie
- Update movie details
- Delete a movie

## Director Management
- Get all directors
- Get director by ID
- Add a new director

## Association Routing
- Retrieve all movies by a specific director

## RESTful API Features
- Attribute Routing
- Proper HTTP Methods
- JSON Request and Response Handling
- Error Handling
- Validation using Required Attributes

## Testing and Debugging
- Swagger UI Testing
- Postman API Testing
- Fiddler HTTP Traffic Monitoring

---

# Technologies Used

- ASP.NET Core Web API
- C#
- .NET 8 / .NET 9
- Swagger / Swashbuckle
- Postman
- Fiddler Classic

---

# Project Structure

```text
MovieCatalogAPI
│
├── Controllers
│   ├── MoviesController.cs
│   └── DirectorsController.cs
│
├── Models
│   ├── Movie.cs
│   └── Director.cs
│
├── Properties
│   └── launchSettings.json
│
├── Program.cs
│
├── appsettings.json
│
├── Screenshots
│   ├── Swagger.png
│   ├── Postman.png
│   └── Fiddler.png
│
└── README.md
```

---

# API Endpoints

## Movie Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/movies | Retrieve all movies |
| GET | /api/movies/{id} | Retrieve movie by ID |
| POST | /api/movies | Create a new movie |
| PUT | /api/movies/{id} | Update existing movie |
| DELETE | /api/movies/{id} | Delete movie |

---

## Director Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/directors | Retrieve all directors |
| GET | /api/directors/{id} | Retrieve director by ID |
| POST | /api/directors | Create a new director |
| GET | /api/directors/{directorId}/movies | Retrieve movies by director |

---

# RESTful Principles Implemented

The API follows RESTful architecture principles by:
- Using meaningful URIs
- Using proper HTTP methods
- Returning appropriate HTTP status codes
- Handling requests and responses in JSON format
- Maintaining resource-based routing

---

# HTTP Methods Used

| HTTP Method | Purpose |
|---|---|
| GET | Retrieve data |
| POST | Create data |
| PUT | Update data |
| DELETE | Remove data |

---

# Attribute Routing

Attribute routing is implemented to define clean and understandable API routes.

Examples:
- /api/movies
- /api/movies/1
- /api/directors/1/movies

This improves route readability and follows RESTful conventions.

---

# Validation and Error Handling

The application includes:
- Required field validation
- NotFound responses for invalid IDs
- Proper HTTP status codes
- Graceful error handling

Common status codes returned:
- 200 OK
- 201 Created
- 204 No Content
- 400 Bad Request
- 404 Not Found

---

# Swagger Testing

Swagger UI is used to:
- View all API endpoints
- Test API requests directly in browser
- Verify responses and status codes

## Swagger Screenshot

Add Swagger UI screenshot here:

```text
Screenshots/Swagger.png
```

Markdown image example:

```markdown
![Swagger Screenshot](Screenshots/Swagger.png)
```

---

# Postman Testing

Postman is used for:
- Sending GET, POST, PUT, DELETE requests
- Testing JSON request bodies
- Verifying API responses
- Testing status codes and validation

## Postman Screenshot

Add Postman screenshot here:

```text
Screenshots/Postman.png
```

Markdown image example:

```markdown
![Postman Screenshot](Screenshots/Postman.png)
```

---

# Fiddler Debugging

Fiddler Classic is used for:
- Monitoring HTTP traffic
- Inspecting requests and responses
- Verifying headers and content types
- Debugging API communication

## Fiddler Screenshot

Add Fiddler screenshot here:

```text
Screenshots/Fiddler.png
```

Markdown image example:

```markdown
![Fiddler Screenshot](Screenshots/Fiddler.png)
```

---

# How to Run the Project

## Step 1
Open the solution in Visual Studio.

## Step 2
Restore NuGet packages.

## Step 3
Build the project.

## Step 4
Run the application using:
- Ctrl + F5

## Step 5
Open Swagger UI or test endpoints using Postman.

---

# How to Test Using Postman

1. Run the API
2. Copy localhost URL
3. Open Postman
4. Send requests using API endpoints
5. Verify JSON responses and status codes

---

# How to Monitor Requests Using Fiddler

1. Open Fiddler Classic
2. Run the ASP.NET Core API
3. Send requests from Postman or Swagger
4. Inspect HTTP traffic in Fiddler
5. Verify request methods, headers, and responses

---

# Learning Outcomes

Through this project, the following concepts were implemented and understood:
- RESTful API development
- CRUD operations
- Attribute routing
- HTTP methods
- API testing
- Request and response handling
- API debugging using Fiddler
- Validation and error handling

---

# Conclusion

The Movie Catalog RESTful API successfully demonstrates the implementation of a RESTful web service using ASP.NET Core. The project includes CRUD operations, routing, validation, testing, and debugging techniques required for modern API development.
