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

## License
This project is licensed under the Creative Commons Attribution-NonCommercial 4.0 International License. 

[![License: CC BY-NC 4.0](https://licensebuttons.net/l/by-nc/4.0/88x31.png)](http://creativecommons.org/licenses/by-nc/4.0/)

You are free to:
- **Share** — copy and redistribute the material in any medium or format
- **Adapt** — remix, transform, and build upon the material

The licensor cannot revoke these freedoms as long as you follow the license terms.

Under the following terms:
- **Attribution** — You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.
- **NonCommercial** — You may not use the material for commercial purposes.

**Notices**:
- You do not have to comply with the license for elements of the material in the public domain or where your use is permitted by an applicable exception or limitation.
- No warranties are given. The license may not give you all of the permissions necessary for your intended use. For example, other rights such as publicity, privacy, or moral rights may limit how you use the material.

For more information, see the [license details](http://creativecommons.org/licenses/by-nc/4.0/).

