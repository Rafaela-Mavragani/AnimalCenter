📘 AnimalCenterApp

AnimalCenterApp is a Blazor Server application designed for managing tasks, volunteers, and animals in an animal care center. It allows administrators to create and assign tasks, manage volunteers, and keep track of what each animal needs — from feeding to medical care.
📌 Features

    ✅ Animal Management: Add, edit, delete animals.

    ✅ User Management: Add and manage users (e.g., volunteers).

    ✅ Task Management:

        Create general tasks (e.g., "Feed", "Clean cage")

        Assign tasks to animals

        Assign tasks to specific volunteers

        Mark tasks as completed

    ✅ Role Support: Administrator vs Volunteer behavior

    ✅ Validation & Error Handling

    ✅ Modern UI with pastel color palette

    ✅ Responsive Layout and accessible interface

🛠️ Technologies Used

    .NET 8 Blazor Server

    C# + Entity Framework Core

    SQL Server

    ASP.NET Core Web API

    Bootstrap 5.3 (CDN)

    Dependency Injection

    Custom Exception Handling

🧩 Project Structure
Folder	Purpose
AnimalCenterAPI	Web API backend with controllers and services
AnimalCenterApp	Blazor Server frontend (UI and logic)
DTO/	Data Transfer Objects
Controllers/	API endpoints
Services/	Business logic layer
Repository/	Data access layer
