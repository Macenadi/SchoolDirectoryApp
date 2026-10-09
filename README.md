##Project Description

As part of the CA1 assignment, the School Directory Dashboard was developed using C# and Blazor.

The main purpose of this project is to retrieve information about schools using the Edutots School API (https://edutots.net/api/school) and display the data in an organised and interactive way.

In this project, users can:
Search for schools.
View school details.
Sort schools from A–Z or Z–A.
Mark schools as favourites.
View only their favourite schools.


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

API endpoint: https://edutots.net/api/school


##

