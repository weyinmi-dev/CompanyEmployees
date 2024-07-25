# CompanyEmployees API

![.NET Core](https://img.shields.io/badge/.NET_Core-6.0-blue)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-Core-green)
![JWT](https://img.shields.io/badge/JWT-Authentication-orange)
![Swagger](https://img.shields.io/badge/Swagger-API_Documentation-brightgreen)

## Overview

The **CompanyEmployees API** is a .NET Core web API that allows companies to manage their employees. Both companies and employees are treated as users within the system. The API is built using Entity Framework Core for database interactions, JWT for secure authentication, and Swagger for API documentation.

## Features

- **User Authentication**: Secure authentication using JSON Web Tokens (JWT).
- **Company Management**: Create, update, and delete company profiles.
- **Employee Management**: Add, update, and manage employees associated with a company.
- **API Documentation**: Interactive API documentation and testing with Swagger.

## Technologies Used

- **.NET Core 6.0**
- **Entity Framework Core**
- **JWT Authentication**
- **Swagger for API Documentation**

## Getting Started

### Prerequisites

- .NET Core 6.0 SDK
- SQL Server (or any other compatible database)
- Visual Studio or any other code editor

### Installation

1. **Clone the repository**:

    ```sh
    git clone https://github.com/weyinmi-dev/CompanyEmployees.git
    ```

2. **Navigate to the project directory**:

    ```sh
    cd CompanyEmployees
    ```

3. **Restore dependencies**:

    ```sh
    dotnet restore
    ```

4. **Update database connection string**:

    Modify the `appsettings.json` file to update the database connection string:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server_name;Database=CompanyEmployeesDB;Trusted_Connection=True;"
    }
    ```

5. **Run database migrations**:

    ```sh
    dotnet ef database update
    ```

6. **Run the application**:

    ```sh
    dotnet run
    ```

### API Documentation

Once the application is running, you can access the Swagger UI for API documentation and testing:


## Usage

### Authentication

- **Register**: Create a new user account (either a company or an employee).
- **Login**: Authenticate and receive a JWT for authorized access.

### Company Management

- **Create a Company**: `POST /api/companies`
- **Get All Companies**: `GET /api/companies`
- **Get a Company by ID**: `GET /api/companies/{id}`
- **Update a Company**: `PUT /api/companies/{id}`
- **Delete a Company**: `DELETE /api/companies/{id}`

### Employee Management

- **Add an Employee**: `POST /api/employees`
- **Get All Employees**: `GET /api/employees`
- **Get an Employee by ID**: `GET /api/employees/{id}`
- **Update an Employee**: `PUT /api/employees/{id}`
- **Delete an Employee**: `DELETE /api/employees/{id}`

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
