# Employee API

A lightweight RESTful Web API built with **ASP.NET Core**, designed as a hands-on learning project covering core C# and .NET concepts: OOP & inheritance, interfaces, dependency injection, async/await, LINQ, and custom exception handling.

## Features

- Full CRUD-style endpoints for managing employees
- Polymorphic employee model (`Employee`, `Manager`, `Developer`) using inheritance
- Interface-based design (`IPayable`, `IEmployeeService`) for testable, decoupled code
- Constructor-based Dependency Injection
- Custom exception type (`EmployeeNotFoundException`) mapped to proper HTTP status codes
- Async service layer using `Task`/`await`
- In-memory data store (no database dependency — easy to run and inspect)
- Interactive API documentation via OpenAPI

## Tech Stack

- **.NET 10** / ASP.NET Core Web API
- C# 13
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
└── Program.cs
```

## Getting Started

### Prerequisites

- [.NET SDK 10](https://dotnet.microsoft.com/download) or later

### Run locally

```bash
git clone https://github.com/OaaMatin/EmployeeApi.git
cd EmployeeApi
dotnet run
```

The API will start on a local port shown in the console output (e.g. `http://localhost:5285`). Open `/scalar/v1` in your browser for interactive API documentation.