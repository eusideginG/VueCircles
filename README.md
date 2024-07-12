# SPA Layout and Functionality Assignment

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Optional Features](#optional-features)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction
This project is a simple Single Page Application (SPA) built using Vue.js or Svelte for the frontend and C# for the backend API. The application provides functionality to capture user interactions on a canvas and stores these interactions in a database.

## Prerequisites
- Node.js and npm (for frontend development)
- .NET Core SDK (for backend development)
- A database (e.g., SQL Server, PostgreSQL)

## Installation

### Frontend
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/your-repo.git
    ```
2. Navigate to the frontend directory:
    ```bash
    cd your-repo/frontend
    ```
3. Install dependencies:
    ```bash
    npm install
    ```
4. Start the development server:
    ```bash
    npm run dev
    ```

### Backend
1. Navigate to the backend directory:
    ```bash
    cd your-repo/backend
    ```
2. Restore .NET dependencies:
    ```bash
    dotnet restore
    ```
3. Update the database connection string in `appsettings.json`.
4. Apply database migrations:
    ```bash
    dotnet ef database update
    ```
5. Run the backend server:
    ```bash
    dotnet run
    ```

## Usage
1. Open your browser and navigate to `http://localhost:8080`.
2. Interact with the input boxes and the canvas as described in the functionality section.

## Features
- **Canvas Interaction**: Click on the canvas to update input boxes with coordinates and draw a circle with random diameter and color.
- **Manual Input**: Manually update the input boxes and press submit to draw a circle with random diameter and color at the specified coordinates.
- **Database Storage**: Each interaction is stored in the database with the following details: time, X, Y, diameter, and color.

## Optional Features
- **Unique URL**: Each session can be accessed via a unique URL (`localhost:8080/ACDKJ43`).
- **Persistent Storage**: If a user navigates to an existing unique URL, previous interactions are displayed on the canvas.
- **Automatic Code Generation**: If no unique code is provided, the system generates one and stores actions under this code.

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License
This project is licensed under the MIT License.

## Contact
For questions or support, please contact:
- Your Name: [your.email@example.com](mailto:your.email@example.com)
- GitHub: [yourusername](https://github.com/yourusername)
