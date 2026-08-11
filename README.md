# Employee API

A lightweight RESTful Web API built with **ASP.NET Core**, covering core C# and .NET concepts: OOP, interfaces, dependency injection, async/await, LINQ, custom exceptions, and EF Core persistence.

## Features

- Full CRUD-style endpoints for managing employees
- Polymorphic employee model (`Employee`, `Manager`, `Developer`) using inheritance
- Interface-based design (`IPayable`, `IEmployeeService`) for testable, decoupled code
- Constructor-based Dependency Injection
- Custom exception type (`EmployeeNotFoundException`) mapped to proper HTTP status codes
- Async service layer using `Task`/`await`
- Persistent storage with **Entity Framework Core** and **SQLite**
- Interactive API documentation via OpenAPI
- Table-Per-Hierarchy (TPH) inheritance mapping for `Manager` and `Developer` subtypes

## Tech Stack

- **.NET 10** / ASP.NET Core Web API
- C# 13
- Entity Framework Core (SQLite provider)
- Built-in OpenAPI (Scalar / Swagger-compatible)

## Project Structure

```
EmployeeApi/
├── Controllers/
│   └── EmployeesController.cs
├── Services/
│   ├── IEmployeeService.cs
│   └── EmployeeService.cs
├── Models/
│   ├── Employee.cs
│   ├── Manager.cs
│   └── Developer.cs
├── Interfaces/
│   └── IPayable.cs
├── Exceptions/
│   └── EmployeeNotFoundException.cs
├── Data/
│   └── AppDbContext.cs
├── Migrations/
│   └── ... (EF Core migration history, auto-generated)
└── Program.cs
```

## Getting Started

### Prerequisites

- [.NET SDK 10](https://dotnet.microsoft.com/download) or later
- [EF Core CLI tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet): `dotnet tool install --global dotnet-ef`

### Run locally

```bash
git clone https://github.com/OaaMatin/EmployeeApi.git
cd EmployeeApi
dotnet restore
```

Apply database migrations to create the local SQLite database:

```bash
dotnet ef database update
```

This creates an `employees.db` file in the project root (excluded from version control — each clone builds its own local database).

Then run the API:

```bash
dotnet run
```

The API will start on a local port shown in the console output (e.g. `http://localhost:5285`). Open `/scalar/v1` in your browser for interactive API documentation.

## API Endpoints

| Method   | Endpoint              | Description                     |
|----------|------------------------|----------------------------------|
| `GET`    | `/api/employees`       | Get all employees               |
| `GET`    | `/api/employees/{id}`  | Get a single employee by ID     |
| `POST`   | `/api/employees`       | Create a new employee           |
| `PUT`    | `/api/employees/{id}`  | Update an existing employee     |
| `DELETE` | `/api/employees/{id}`  | Delete an employee by ID        |
| `POST`   | `/api/employees/managers`   | Create a new manager       |
| `POST`   | `/api/employees/developers` | Create a new developer     |
