# JWT Authentication & Authorization in ASP.NET Core (.NET 10)

This repository contains a complete implementation of **JWT Authentication and Authorization** using **ASP.NET Core Web API (.NET 10)**.

The project demonstrates how to build a secure authentication system with **JWT tokens, role-based authorization, and protected endpoints**.
It was developed step-by-step as part of a **YouTube tutorial series** to explain real-world authentication workflows in ASP.NET Core.

---

# Features

* User Registration
* User Login
* Secure Password Hashing
* JWT Access Token Generation
* JWT Bearer Authentication
* Role-Based Authorization (Admin / User)
* Protected API Endpoints
* Entity Framework Core Integration
* SQL Server Database
* Clean Architecture (Controllers, Services, DTOs, Entities)

---

# Tech Stack

* **.NET 10**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **SQL Server**
* **JWT (JSON Web Tokens)**
* **PasswordHasher**
* **OpenAPI / Scalar**

---

# Project Structure

```text
JWTauth
│
├── Controllers
│   └── AuthController.cs
│
├── Data
│   └── UserDbContext.cs
│
├── DTO
│   └── UserDto.cs
│
├── Entities
│   └── User.cs
│
├── Services
│   ├── IAuthService.cs
│   └── AuthService.cs
│
├── Program.cs
└── appsettings.json
```

---

# Configuration

Update **appsettings.json** with your JWT settings and database connection.

```json
"Token": {
  "Key": "your-super-secret-key",
  "Issuer": "your-issuer",
  "Audience": "your-audience"
},
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=JwtAuthDb;Trusted_Connection=True;"
}
```

---

# Database Setup

Install required NuGet packages:

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.EntityFrameworkCore.SqlServer

Run migrations:

```bash
Add-Migration Initial
Update-Database
```

This will create the database and required tables.

---

# Running the Application

Run the project using:

```bash
dotnet run
```

The API will start and OpenAPI documentation will be available.

---

# Authentication Flow

1. User registers using
   `POST /api/auth/register`

2. User logs in using
   `POST /api/auth/login`

3. Server generates a **JWT token**

4. Client sends the token with requests using:

```
Authorization: Bearer <your-token>
```

# Testing the API

You can test all endpoints using:

* **Scalar UI**
* **Swagger / OpenAPI**
* **Postman**

These tools allow you to authenticate, generate tokens, and test protected routes.

---

# Future Improvements

* Refresh Token implementation
* Password reset functionality
* Role management APIs
* Unit testing
