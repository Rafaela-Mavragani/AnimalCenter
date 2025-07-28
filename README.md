# 🐾 AnimalCenterApp

**AnimalCenterApp** is a Blazor Server application designed to help animal care centers efficiently manage animals, volunteers, and daily tasks. Administrators can track animal needs (feeding, cleaning, medical care), assign tasks to volunteers, and maintain a smooth workflow.

---

## 📌 Features

- ✅ **Animal Management**: Add, edit, and delete animal profiles.
- ✅ **Volunteer/User Management**: Create and manage user accounts (e.g., volunteers).
- ✅ **Task Management**:
  - Create general tasks (e.g., "Feed", "Clean Cage")
  - Assign tasks to specific animals
  - Assign tasks to volunteers
  - Track task completion status
- ✅ **Role-Based Access**: Different views and actions for Admins vs Volunteers.
- ✅ **Form Validation & Error Handling**
- ✅ **Modern UI**:
  - Pastel color palette
  - Responsive layout

---

## 🧰 Tech Stack

- .NET 8 Blazor Server
- C# + Entity Framework Core
- SQL Server
- ASP.NET Core Web API
- Bootstrap 5.3 (via CDN)
- Dependency Injection
- Custom Exception Handling

---

## 📁 Project Structure

| Folder / Project       | Purpose                                |
|------------------------|----------------------------------------|
| `AnimalCenterAPI`      | Web API backend with controllers & services |
| `AnimalCenterApp`      | Blazor Server frontend (UI & logic)    |
| `DTO/`                 | Data Transfer Objects                  |
| `Controllers/`         | API Endpoints                          |
| `Services/`            | Business Logic Layer                   |
| `Repository/`          | Data Access Layer                      |

---

## ⚙️ Setup Instructions

 1. Clone the repository
 2. Open the solution
 3. Set Startup Projects:
    Make sure both projects run together:
    Right-click on the solution > Set Startup Projects...
    Choose Multiple startup projects
    Set both AnimalCenterAPI and AnimalCenterApp to Start
   4. Create the database
   5. Configure connection string
   6. Apply EF Core migrations
   7. Run the application
-------
Admin is harcoded on  AnimalAppDbContext

