# School Directory Dashboard

## Project Description

As part of the CA1 assignment, the School Directory Dashboard was developed using C# and Blazor.

The main purpose of this project is to retrieve information about schools using the Edutots School API (https://edutots.net/api/school) and display the data in an organised and interactive way.

In this project, users can:

- Search for schools.
- View school details.
- Sort schools from A–Z or Z–A.
- Mark schools as favourites.
- View only their favourite schools.

## Technologies Used

- **C#:** The programming language we have been learning in class and used to develop this project.
- **Blazor:** Used to build the web application.
- **.NET:** Used to run the project.
- **Bootstrap:** Used to organise the elements and improve the layout.
- **HTML and CSS:** Used to structure and style the application.
- **HttpClient:** Used to retrieve information from the API.
- **Git and GitHub:** Used for version control and to store the project.
- **Visual Studio:** Used to develop and test the application.

## API Integration

For this project, I worked with the Edutots API, which was provided as part of the CA1 assignment, to retrieve information about schools.

The `SchoolService` class uses `HttpClient` to make requests to the API. The data is received in JSON format and converted into C# objects using the `School` class.

**API endpoint:** https://edutots.net/api/school

## Main Features

- Retrieve and display a list of schools using the API.
- Search for schools by name.
- Use a button to show or hide school details.
- Display a loading message while the data is being retrieved.
- Display an error message if the application cannot retrieve data from the API.

## Additional Features

- Sort school names in alphabetical order (A–Z or Z–A).
- Mark schools as favourites or remove them from the favourites list.
- Filter the list to display only favourite schools.
- Use a Refresh button to retrieve updated data from the API.
- View a statistics dashboard with cards showing the total number of schools, favourite schools and schools currently displayed.
- Use a responsive layout that adapts to desktop and mobile screens.

## How to Run the Application

The project is available on GitHub:

https://github.com/Macenadi/SchoolDirectoryApp.git

To run the application:

1. Clone or download the project from the GitHub repository.
2. Open the `SchoolDirectoryApp.sln` file in Visual Studio.
3. Restore the project dependencies if necessary.
4. Run the application by pressing `F5`.
5. Select "Schools" from the navigation menu or enter `/schools` in the browser's address bar.

An internet connection is required to retrieve information from the Edutots API.

## Screenshots

Screenshots of the application will be added to demonstrate:

- School list loaded successfully.
- Search functionality.
- School details view.
- Loading state.
- Error handling.
- Statistics dashboard.
- Responsive mobile layout.


## Screenshots

The following screenshots demonstrate the main features of the application.

1. [Loading State](screenshots\Loading.png)
2. [School List](screenshots\SchoolList.png)
3. [Search Functionality](screenshots/Search.png)
4. [No Favourite Schools](screenshots/NoFavourites.png)
5. [Favourite Schools](screenshots/FavoriteSchools.png)
6. [School Details](screenshots/SchoolDetails.png)
7. [Sorting Schools](screenshots/Sorting.png)
8. [Error Handling](screenshots/Error.png)
  