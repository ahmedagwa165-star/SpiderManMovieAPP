🕷️ SpidermanMovieAPP

A simple ASP.NET Core 9 MVC web application that displays a catalog of Spider-Man movies using in-memory data.

📌 Project Overview

SpidermanMovieAPP is an ASP.NET Core MVC web application developed using C# and Bootstrap.

The application provides a simple movie catalog where users can:

- View a list of Spider-Man movies.
- Open the details of any movie.
- View the movie's director and release year.
- Navigate back to the movies catalog.

The project uses an in-memory "List<Movie>" instead of an external database.

🛠️ Technologies Used

- ASP.NET Core 9
- MVC (Model-View-Controller)
- C#
- HTML5
- CSS3
- Bootstrap
- Visual Studio
- GitHub

📂 Project Structure

SpidermanMovieAPP
│
├── Controllers
│   └── MoviesController1.cs
│
├── Models
│   └── Movie.cs
│
├── Views
│   └── Movies
│       ├── Index.cshtml
│       └── Details.cshtml
│
├── wwwroot
│   ├── css
│   └── js
│
├── Program.cs
└── README.md

🎬 Movie Model

The "Movie" model contains the following properties:

Property| Type| Description
Id| "int"| Unique identifier for the movie
Title| "string"| Movie title
Director| "string"| Movie director
ReleaseYear| "int"| Movie release year

🧠 Data Handling

The application stores movie information using an in-memory collection:

List<Movie>

No external database is required for this project.

🖥️ Application Views

🏠 Index View

The Index page displays the complete Spider-Man movie catalog.

Users can select a movie to view its individual details.

🎥 Details View

The Details page displays information about the selected movie, including:

- Movie Title
- Director
- Release Year

It also contains a button to return to the movies catalog.

🚀 Startup Route

The application is configured in "Program.cs" to open the movies catalog directly when the application starts.

The default route is:

{controller=Movies}/{action=Index}/{id?}

Therefore, the Movies → Index page is displayed automatically when the application runs.

🎨 UI & Styling

The application uses:

- Bootstrap for responsive and clean UI components.
- HTML5 for page structure.
- CSS3 for additional styling.

▶️ How to Run

1. Clone the repository.
2. Open the project in Visual Studio.
3. Restore the required .NET dependencies.
4. Build the project.
5. Run the application using Visual Studio.

The application will open directly on the Spider-Man movies catalog.

📚 Project Purpose

This project demonstrates the basic concepts of ASP.NET Core MVC, including:

- Models
- Controllers
- Views
- Routing
- Passing data from Controller to View
- Razor Views
- In-memory data collections
- Bootstrap styling

📌 GitHub Repository Information

Project Name: "SpidermanMovieAPP"

Description:

«A simple ASP.NET Core 9 MVC web application showcasing a list of Spider-Man movies with in-memory data, dynamic details view, and Bootstrap styling.»

GitHub Topics

aspnet-core
dotnet
mvc
csharp
bootstrap
spiderman

---

👨‍💻 Author

Ahmed Saad Agwa

Developed using ASP.NET Core 9 MVC and C#.
