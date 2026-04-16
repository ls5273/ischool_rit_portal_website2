# 💻 iSCHOOL @ RIT PORTAL WEBSITE (2)

## 📌 Overview:
- The iSchool @ RIT web application is a server-side rendered ASP.NET Core MVC application. It serves as an informational portal for academic programs, faculty directories, and employment outcomes. By utilizing a custom API service, the application fetches live institutional data and processes it backend-first, delivering fast and fully formed HTML directly to the client.

## ✨ Key Features:
- **MVC Architecture:** Implements a strict Model-View-Controller design pattern, cleanly separating data structures, business logic, and UI rendering.
- **Robust API Integration:** Utilizes an injected HttpClient service (ApiService) to execute asynchronous GET requests to external REST APIs.
- **Strongly-Typed Data Models:** Deserializes raw JSON data into strongly-typed C# objects, ensuring type safety and IntelliSense support throughout the application.
- **Centralized API Routing:** Stores all external API endpoint URLs in a static, centralized ApiEndpoints class to maintain clean and easily updatable controller logic.
- **Server-Side Rendering (SSR):** Dynamically generates HTML on the server by passing fetched API models directly to the views before sending the payload to the browser.
- **Client-Side Libraries:** Integrates standard third-party libraries like Bootstrap for responsive layouts and jQuery for client-side interactions and validation.
  
## 🛠️ Tech Stack:
- **Backend:** C# and ASP.NET Core MVC.
- **Data Fetching:** HttpClient / System.Net.Http.Json for asynchronous REST API consumption.
- **Frontend:** HTML5, CSS3, Bootstrap, and jQuery.
