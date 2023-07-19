# Lazerpay
Lazerpay is an airline reservation system that allows users to search for and book flights. Built with C# and MySQL, the application offers a user-friendly interface and comprises four forms:

* __Flight Checker__: This form enables users to search for flights using their departure airport, arrival airport, and date.
* __Flight Booker__: The form displays the results of the search and enables users to book their chosen flight. Also allows you to add children and luggages. What is an Airline reservation system without these?
* __Flight Checkout__: This form presents a summary of the user's billing information and collects their personal details, generating a text file that is saved in the downloads folder.
* __Database Populator__: This form allows an admin user to add flights to the database.

Lazerpay's interface is designed to be intuitive and easy to navigate, providing a seamless experience for users. The application is written in highly optimized and easy to understand code.

# Features
An airline reservation system should be able to do the following (lazerpay can do all these):
* Search for flights using departure airport, arrival airport, and date.
* Book selected flights.
* Add Children and Luggages in real-time.
* View a summary of billing information and personal details before checkout.
* Generate a text file with booking details.
* Add flights to the database using the admin form.

# Requirements
* Windows operating system
* [Xampp](https://drive.google.com/file/d/12rWcfQlUrQ2QN0E_krZOPUGXfcyIgrXo/view?usp=drive_link)
* [Microsoft Visual Studio Community](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030)
* [Microsoft Sql Connector](https://drive.google.com/file/d/12qoLS1aX0ec0-biMXLyxeurMUCJYC9Kv/view?usp=drive_link)

# Installation
1. Clone the repository to your local machine.
2. Open the solution file (Lazerpay.sln) in Visual Studio.
3. Build the solution.
4. Start a MySQL server instance and create a new database.
5. Update the connection string in the suitable_flights.cs file to point to the new database.
6. Populate the database by running populatedb.cs
7. Run the application.

# Contributing
Contributions to Lazerpay are welcome! If you find a bug or would like to suggest an enhancement, please open an issue on the repository. If you would like to contribute code, please fork the repository, create a new branch, and submit a pull request.

# License
Lazerpay is licensed under the MIT License. See LICENSE for more information.

# Contact
If you have any questions or feedback, please don't hesitate to contact me at interesting.tobi@gmail.com.
