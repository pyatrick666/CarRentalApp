# CarRentalApp — Vehicle Rental Booking System

A Windows desktop application built with **C# and Windows Forms** for recording and reviewing vehicle rental bookings. The project uses **Microsoft SQL Server** for persistent booking data.

> Screenshots and a walkthrough will be added in a later update.

## Overview

The application provides a guided flow from a welcome screen to login and the main dashboard. Its booking form collects renter details, vehicle preferences, rental duration, and optional services. Booking records are stored in the SQL Server `dbo.bookinginfo` table.

## Features

- Welcome and login screens
- Dashboard navigation
- Vehicle rental booking form
- Capture renter details, age, driving-licence status, rental days, car type, and fuel type
- Optional unlimited-mileage and breakdown-cover selections
- Save booking records to SQL Server
- View existing rental records
- Search bookings by booking ID, first name, or last name

## Technology

| Area | Implementation |
| --- | --- |
| Language | C# |
| Desktop UI | Windows Forms |
| Data access | ADO.NET with `Microsoft.Data.SqlClient` |
| Database | Microsoft SQL Server |
| Query style | Parameterized SQL commands |

## Main files

| File | Responsibility |
| --- | --- |
| `Program.cs` | Application entry point |
| `Welcomescreen.cs` | Welcome screen |
| `Login_page.cs` | Login screen |
| `dashboard.cs` | Main dashboard |
| `bookingform.cs` | New booking form |
| `ViewRentals.cs` | View and search rental records |
| `BookingRepos.cs` | SQL Server booking insert, retrieval, and search operations |
| `App.config` | Application and database connection configuration |

## Requirements

- Windows
- Visual Studio with the .NET Framework targeting components required by the project
- Microsoft SQL Server
- A database containing the expected `dbo.bookinginfo` table

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/pyatrick666/CarRentalApp.git
   ```
2. Open `WindowsFormsApp1.sln` in Visual Studio.
3. Configure the `BookingDB` connection string in `App.config` for your local SQL Server instance.
4. Create the database and `dbo.bookinginfo` table with the columns used by `BookingRepos.cs`.
5. Restore the NuGet packages referenced by the project.
6. Build and run the application from Visual Studio.

Do not commit real database passwords or production connection strings.

## Data fields

The booking model includes booking ID, renter name, address, age, driving-licence status, rental days, car type, fuel type, unlimited mileage, and breakdown cover.

## Notes and limitations

- This is a desktop coursework/personal project, not a hosted booking service.
- The implementation uses SQL Server, not MySQL.
- Authentication and database deployment should be reviewed and tested before using the application with real customer information.

## Author

**Pratik Poudel** · [Portfolio](https://pratikpoudel.info.np/) · [GitHub](https://github.com/pyatrick666)
