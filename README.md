# SWAPI Project

A full-stack application built around the Star Wars API (SWAPI), featuring a modern web application, mobile application, and .NET backend.

The project is currently under active development.

## Overview

This project provides a unified Star Wars experience across web and mobile platforms. It consists of three main applications:

* **Backend API** built with .NET 10
* **Web application** built with Angular 22
* **Mobile application** built with Flutter

The backend acts as the central layer for the applications and handles communication with SWAPI, application logic, and future backend services.

## Architecture

The backend follows **Clean Architecture**, with the solution organized into the following layers:

* **API**: Handles HTTP requests, endpoints, middleware, and communication with client applications.
* **Application**: Contains application use cases, business workflows, interfaces, and application-specific logic.
* **Domain**: Contains the core business entities, rules, and domain logic. This layer is independent of external frameworks and infrastructure.
* **Infrastructure**: Contains implementations for external concerns such as data access, third-party API integrations, and other services.

<img width="1536" height="1024" alt="arc" src="https://github.com/user-attachments/assets/37a890fc-4f5c-44c8-b447-228cc2f1443f" />

## Tech Stack

### Backend

* .NET 10
* ASP.NET Core Web API
* Clean Architecture
* RESTful APIs
* SWAPI integration

### Web

* Angular 22
* TypeScript
* HTML
* CSS

### Mobile

* Flutter
* Dart

## Project Structure

The repository is organized into separate applications for the backend, web, and mobile platforms.

```text
StarWars/
│
├── backend/
│   ├── src/
│   │   ├── API/
│   │   │   ├── Properties/
│   │   │   ├── API.http
│   │   │   ├── appsettings.json
│   │   │   ├── appsettings.Development.json
│   │   │   └── Program.cs
│   │   │
│   │   ├── Application/
│   │   ├── Domain/
│   │   └── Infrastructure/
│   │       └── Swapi/
│   │
│   └── test/
│       └── Backend.Tests/
│           └── UnitTest1.cs
│
├── web/
│   └── ...
│
├── mobile/
│   └── ...
│
└── README.md
```

> The exact project structure may change as development continues.

## Features

The application is currently under development. Planned and implemented features may include:

* Browse Star Wars characters
* View detailed character information
* Explore planets
* Browse Star Wars films
* Explore starships and vehicles
* Search for Star Wars content
* Responsive web experience
* Native cross-platform mobile experience
* Centralized backend API integration with SWAPI

## Prerequisites

Before running the project locally, make sure you have the following installed:

### Backend

* .NET 10 SDK

### Web

* Node.js
* npm
* Angular CLI

### Mobile

* Flutter SDK
* Dart SDK
* Android Studio or Xcode, depending on your target platform

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/Merve-1/StarWars
cd StarWars
```

## Running the Backend

Navigate to the backend project:

```bash
cd backend/API
```

Restore dependencies:

```bash
dotnet restore
```

Run the application:

```bash
dotnet run
```

The API will start on the configured local development URL.

## Running the Web Application

Navigate to the Angular project:

```bash
cd web/swapi-web
```

Install dependencies:

```bash
npm install
```

Start the development server:

```bash
ng serve
```

Open the application in your browser using the URL displayed by Angular, typically:

```text
http://localhost:4200
```

## Running the Mobile Application

Navigate to the Flutter project:

```bash
cd mobile/swapi_mobile
```

Install dependencies:

```bash
flutter pub get
```

Run the application:

```bash
flutter run
```

Make sure an emulator, simulator, or physical device is available before running the application.

## API Integration

The .NET backend is responsible for handling communication between the client applications and SWAPI.

This approach allows the web and mobile applications to use a consistent backend API rather than directly duplicating integration logic.

## Configuration

Configuration details such as API URLs and environment-specific settings should be stored separately for each application.

Examples include:

* Backend application settings
* Angular environment configuration
* Flutter environment or application configuration

Sensitive information should not be committed to the repository. Use environment variables or local configuration files where appropriate.

## API Documentation

API documentation will be available as the backend evolves.

Future documentation may include:

* Available endpoints
* Request parameters
* Response models
* Error responses
* Authentication requirements

## Testing

Testing is planned across all parts of the application.

### Backend

```bash
dotnet test
```

### Web

```bash
ng test
```

### Mobile

```bash
flutter test
```

## Development Status

🚧 **Work in Progress**

This project is actively being developed. Features, architecture, folder structure, and documentation may change as the project evolves.

## Future Improvements

Some potential improvements include:

* Authentication and authorization
* User favorites
* Advanced search and filtering
* Caching for SWAPI responses
* Database integration
* Improved error handling
* Automated testing
* CI/CD pipelines
* Docker support
* API versioning
* Improved API documentation
* Dark mode
* Additional Star Wars data and features

**Built with .NET 10, Angular 22, Flutter, and SWAPI.**
