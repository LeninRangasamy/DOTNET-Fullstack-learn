
#  ASP.NET Web API Project

This repository contains a practical project built using **ASP.NET Web API** to demonstrate RESTful API development using the Microsoft .NET ecosystem.

---

## Project Overview

This project showcases:

* RESTful API development
* CRUD operations
* Clean architecture structure
* Database integration
* Authentication & Authorization
* Error handling & middleware usage

---

## Tech Stack

* **Framework:** ASP.NET Web API
* **Runtime:** Microsoft .NET
* **ORM:** Entity Framework Core
* **Database:** SQL Server
* **API Testing:** Postman
* **IDE:** Visual Studio

---

## Features

* RESTful endpoints (GET, POST, PUT, DELETE)
* Database integration with EF Core
* Repository pattern implementation
* DTO usage
* Dependency Injection
* JWT Authentication
* Role-based Authorization
* Global exception handling
* Swagger documentation
* Pagination, filtering & sorting

---

## 📂 Project Structure

```
/Controllers
/Models
/DTOs
/Repositories
/Services
/Data
/Middleware
```

---

## ▶️ How to Run the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```

2. Open the solution in Visual Studio

3. Update the `appsettings.json` file with your SQL Server connection string

4. Apply migrations:

   ```bash
   dotnet ef database update
   ```

5. Run the project:

   ```bash
   dotnet run
   ```

6. Access Swagger UI in your browser:

   ```
   https://localhost:{port}/swagger
   ```

---

## Authentication

This API uses JWT (JSON Web Token) authentication.

* Register / Login to receive a token
* Add the token to the Authorization header:

  ```
  Bearer your_token_here
  ```

---

## Objectives Achieved

* Build scalable and maintainable APIs
* Implement secure authentication
* Follow clean architecture principles
* Connect and manage relational databases

---

## Future Improvements

* Unit Testing (xUnit)
* Integration Testing
* Docker Support
* CI/CD Integration

---

## Support

If you find this project helpful, feel free to give it a star ⭐

