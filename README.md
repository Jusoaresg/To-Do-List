# To-Do List Web Application

## Overview

This is a simple To-Do List web application built using ASP.NET MVC. The application provides functionality to create, edit, and delete tasks. Each task comprises a Title, Description, and a boolean indicator for completion status.

## Features

- **Task Management**: Create, edit, and delete tasks effortlessly.
- **Task Details**: Each task includes a Title, Description, and a completion status indicator.
- **Persistent Storage**: The application uses a SQL Server database to store task information. To set up the database, modify the `DefaultConnection` in the `appsettings` file.

## Getting Started

To run the application locally, follow these steps:

1. Clone this repository to your local machine.
   ```
   git clone https://github.com/your-username/todo-list.git
2. Setup the Connection string to the database on appsettings.json
   ```
   "DefaultConnection": "Server=your-server;Database=your-database;User Id=your-username;Password=your-password;"
