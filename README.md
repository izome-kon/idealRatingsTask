
# 🌟 Ideal Ratings Task


## 📖 Table of Contents

- [📝 Task Overview](#-task-overview)
- [✅ Tasks Completed](#-tasks-completed)
- [🧱 Project Structure](#-project-structure)
- [🛠️ Technologies Used](#️-technologies-used)
- [🎨 Design Patterns Used](#-design-patterns-used)
- [🚀 How to Run this Application](#-how-to-run-this-application)
    - [Clone the Repository](#clone-the-repository)
    - [Setup the Environment Variables](#setup-the-environment-variables)
        - [Frontend `.env`](#frontend-env)
        - [Backend Node.js `.env`](#backend-nodejs-env)
- [🚢 Running the Project with Docker Compose](#-running-the-project-with-docker-compose)
- [🗂️ Database Seeding](#️-database-seeding)
- [🔌 API Route (Node.js)](#-api-route-nodejs)
    - [📍 Endpoint](#-endpoint)
    - [🔄 Query Parameters (Optional)](#-query-parameters-optional)
    - [🧾 Sample Request](#-sample-request)
    - [✅ Sample Response](#-sample-response)
    - [🔧 How It Works](#-how-it-works)
- [📌 API Route (.NET)](#-api-route-net)
    - [📍 Endpoint](#-endpoint-1)
    - [🔄 Query Parameters (Optional)](#-query-parameters-optional-1)
    - [🧾 Sample Request](#-sample-request-1)
    - [✅ Sample Response](#-sample-response-1)
    - [🔧 How It Works](#-how-it-works-1)
- [🧪 Unit Testing Guide for Node.js (Jest)](#-unit-testing-guide-for-nodejs-jest)
    - [📦 Location of Tests](#-location-of-tests)
    - [▶️ Running the Tests](#️-running-the-tests)
    - [📁 Sample Test Command Output](#-sample-test-command-output)
- [🔧 Troubleshooting](#-troubleshooting)
    - [Error When Running Migration](#error-when-running-migration)
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


## 🎨 Design Patterns Used


1. **Repository Pattern**:
    - Used in both Node.js and .NET backends to abstract data access logic and provide a clean separation between the business logic and data sources (CSV, MongoDB, SQL Server).

2. **Dependency Injection**:
    - Implemented in both Node.js and .NET backends to manage dependencies and improve testability by injecting required services into controllers and services.

3. **Mapper Pattern**:
    - Applied to transform raw data from different sources (CSV, MongoDB, SQL Server) into a unified format for the API response.


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
docker compose up -d
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

## 🔌 API Route (Node.js)

The Node.js backend exposes a single RESTful API endpoint to fetch and filter person details aggregated from both a **CSV file** and a **MongoDB database**.

### 📍 Endpoint

```
GET /api/person
```

### 🔄 Query Parameters (optional):

| Parameter | Type   | Description                                     |
|-----------|--------|-------------------------------------------------|
| `name`    | string | Filter results by person’s name                 |
| `country` | string | Filter results by country                       |

### 🧾 Sample Request

```http
GET http://localhost:3000/api/person?name=Mohamed&country=egypt
```

### ✅ Sample Response

```json
[
    {
        "first name": "Mohamed",
        "last name": "Khaled",
        "telephone code": "20",
        "telephone number": "444444030",
        "address": "11 Road Street",
        "country": "Egypt"
    }
]
```

### 🔧 How It Works

- The API aggregates person data from:
  - A **CSV file** located in the project directory (`backend_nodejs/src/data/person.csv`)
  - A **MongoDB collection** (`persons`)
- The response is **combined** from both sources and **formatted uniformly**.
- If no filters are passed, all records are returned.

## 📌 API Route (.NET)

This backend is implemented using ASP.NET Core 7 and exposes a single RESTful API for retrieving person details.

---

### 📍 Endpoint

### `GET /api/person`

Fetch a list of all persons with optional filters.

### 🔄 Query Parameters (optional):

| Parameter | Type   | Description                          |
|-----------|--------|--------------------------------------|
| `name`    | string | (Optional) Filter by person’s name   |
| `country` | string | (Optional) Filter by country         |

### 🧾 Sample Request

```
GET http://localhost:5009/api/person?name=Ahmed&country=Egypt
```

### ✅ Sample Response

```json
[
    {
        "first name": "Ahmed",
        "last name": "Amr",
        "telephone code": "20",
        "telephone number": "122002020",
        "address": "10 Road Street",
        "country": "Egypt"
    },
    {
        "first name": "Ahmed",
        "last name": "Mohammed",
        "telephone code": "20",
        "telephone number": "010334445",
        "address": "10 Road Street",
        "country": "Egypt"
    }
]
```
---
### 🔧 How It Works

- The API aggregates person data from:
  - A **CSV file** located in the project directory (`BackendDotNet/TechnicalTaskIdealRatingsDotNet/Data/person.csv`)
  - A **Sql Server get all data from** (`Person_Details`) table.
- The response is **combined** from both sources and **formatted uniformly**.
- If no filters are passed, all records are returned.


## 🧠 Note

- You can use this endpoint in the frontend by switching `VITE_BACKEND_ENV=dotnet` in your `.env` file.



## 🧪 Unit Testing Guide for Node.js (Jest)


### 📦 Location of Tests

Unit tests can be found in:

```
backend_nodejs/tests/
```

---

### ▶️ Running the Tests

First, make sure dependencies are installed:

```bash
npm install
```

Then, run the test suite with:

```bash
npm test
```

---

### ⚙️ Tech Stack

- **Jest**: Testing framework
- **ts-jest**: Jest transformer for TypeScript

---

### 📁 Sample Test Command Output

```bash
 PASS  tests/mappers/mongoPerson.mapper.test.ts
 PASS  tests/services/person.service.test.ts
 PASS  tests/mappers/csvPerson.mapper.test.ts
 PASS  tests/utils/buildPersonFilter.test.ts
 PASS  tests/repositories/CsvPersonRepository.test.ts
 PASS  tests/repositories/MongoPersonRepository.test.ts

Test Suites: 6 passed, 6 total
Tests:       21 passed, 21 total
Snapshots:   0 total
Time:        2.975 s, estimated 3 s
Ran all test suites.
```

## 🔧 Troubleshooting

### Error when running migration:

If you encounter an error while running migrations, make sure the database containers are up and running, and ensure the correct credentials are specified in the `.env` file.

### Permissions Issue with Docker:

Make sure Docker has permission to access all the necessary files on your system, especially for file copying operations during container builds.

---

## 📬 Contact

If you have any questions reach out to me at [mahmoud.met58@gmail.com](mailto:mahmoud.met58@gmail.com).