
# 🌟 Ideal Ratings Task


## 📖 Table of Contents

- [📝 Task Overview](#-task-overview)
- [✅ Tasks Completed](#-tasks-completed)
- [🧱 Project Structure](#-project-structure)
- [🛠️ Technologies Used](#️-technologies-used)
- [🚀 How to Run this application](#-how-to-run-this-application)
    - [Clone the Repository](#clone-the-repository)
    - [Setup the Environment Variables](#setup-the-environment-variables)
        - [Frontend `.env`](#frontend-env)
        - [Backend Node.js `.env`](#backend-nodejs-env)
- [🚢 Running the Project with Docker Compose](#-running-the-project-with-docker-compose)
- [🗂️ Database Seeding](#️-database-seeding)
- [🔧 Troubleshooting](#-troubleshooting)
    - [Error when running migration](#error-when-running-migration)
    - [Permissions Issue with Docker](#permissions-issue-with-docker)
- [📬 Contact](#-contact)



## 📝 Task Overview

This application is designed to list person details, including their names, phone numbers, and addresses. The data is aggregated from two sources: a CSV file and a database (MongoDB or SQL Server). Users can filter the displayed list of person details by the person's name and country.

## ✅ Tasks Completed

All the requirements for the task have been successfully implemented:

1. **RESTful API**: A single endpoint was created to list person details from both data sources (CSV and database). The API supports filtering by name and country.
2. **Frontend**: The frontend was implemented using React.
3. **Data Aggregation**: The API reads and combines data from both sources and formats it as per the expected response.
4. **Design Pattern**: The Repository Pattern and Dependency Injection was used in the API implementation to abstract data access logic.
5. **Dockerization**: Docker images were created for all services, and Docker Compose is used to orchestrate them.
6. **Unit Tests**: Unit tests were written for the API to ensure functionality and reliability. (Node.js)

---

## 🧱 Project Structure

```
.
├── frontend                      # Frontend (React)
├── backend_nodejs                # Backend using Node.js
├── BackendDotNet                 # Backend using .NET Core
├── docker-compose.yml            # Docker Compose to run the full stack
└── README.md                     # Project documentation
```

---

## 🛠️ Technologies Used

- **Frontend**: React (Vite)
- **Backend 1**: ASP.NET Core 7
- **Backend 2**: Node.js (Express)
- **Database 1**: MongoDB
- **Database 2**: SQL Server (MSSQL)
- **Containerization**: Docker, Docker Compose
- **Others**: C#, JavaScript, HTML, CSS

---

## 🚀 How to Run this application

To get started with the project, follow the steps below:

### Clone the Repository

```bash
git clone https://github.com/izome-kon/idealRatingsTask.git
cd idealRatingsTask
```

### Setup the Environment Variables

### Create `.env` Files

#### Frontend `.env`

Create a `.env` file in the `frontend` directory with the following content:

```env
VITE_NODE_API_BASE_URL=http://localhost:3000/api

VITE_DOTNET_API_BASE_URL=http://localhost:5009/api

# select what want to use for backend nodejs or dotnet
VITE_BACKEND_ENV=nodejs
```

### ⚠️ Important Note

If you want to change the backend data source, simply update the `VITE_BACKEND_ENV` variable in the `.env` file located in the `frontend` directory.

For example:
```env
VITE_BACKEND_ENV=nodejs
```

Set it to `nodejs` to use the Node.js backend or `dotnet` to use the .NET backend.


#### Backend Node.js `.env`

Create a `.env` file in the `backend_nodejs` directory with the following content:

```env
PORT = 3000

# For MongoDB
MONGO_URI="mongodb://mongo:27017/IdealRatings"
```

---

### 🚢 Running the Project with Docker Compose

1. **Navigate to the project root directory**:

2. **Build the containers**:

```bash
docker compose build
```

3. **Start the services**:

```bash
docker compose up
```

4. **Access the application**:
This will start all the services:
- Frontend (React app): [http://localhost:5173](http://localhost:5173)
- Backend 1 (ASP.NET Core API): [http://localhost:5009](http://localhost:5009)
- Backend 2 (Node.js API): [http://localhost:3000](http://localhost:3000)
- MongoDB: `localhost:27017`
- SQL Server: `localhost:1433`

## 🗂️ Database Seeding

When the application starts for the first time, the database will be seeded with sample data.

---

## 🔧 Troubleshooting

### Error when running migration:

If you encounter an error while running migrations, make sure the database containers are up and running, and ensure the correct credentials are specified in the `.env` file.

### Permissions Issue with Docker:

Make sure Docker has permission to access all the necessary files on your system, especially for file copying operations during container builds.

---

## 📬 Contact

If you have any questions reach out to me at [mahmoud.met58@gmail.com](mailto:mahmoud.met58@gmail.com).