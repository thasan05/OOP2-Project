# DentalCare (HealthCare Plus)

A desktop clinic management system built with C# WinForms and SQL Server, developed as an Object-Oriented Programming II coursework project.

> **Note:** The application's internal namespace and database are named `HealthCare_Plus` / `Healthcareplus`, while the repository and solution are named `DentalCare`. Both names refer to the same project.

## Overview

DentalCare models the day-to-day operations of a small clinic: staff and admin accounts sign in through role-based logins, and each role gets a dashboard scoped to what they're allowed to do — admins manage staff and doctor records, both roles manage patients.

## Features

- **Role-based authentication** — separate login screens for Admin and Staff (`Forms/Auth`)
- **Admin dashboard** — manage staff accounts, doctor records, and patients (`Forms/Dashboard/Admin`)
- **Staff dashboard** — day-to-day staff view with doctor lookups (`Forms/Dashboard/Staff`)
- **Data models** for Users, Patients, Doctors, and Staff Members (`Models/`)
- **SQL Server backend** via ADO.NET (`System.Data.SqlClient`), with a single connection helper (`Utils/DBCon.cs`)
- **Input validation** helper (`Utils/InputValidator.cs`)

## Tech Stack

| Layer | Technology |
|---|---|
| UI | Windows Forms (.NET Framework 4.8) |
| Language | C# |
| Database | Microsoft SQL Server (SQL Express by default) |
| Data access | ADO.NET (`System.Data.SqlClient`) |

## Project Structure

```
DentalCare/
├── Forms/
│   ├── Auth/           # AdminLogin, StaffLogin
│   └── Dashboard/
│       ├── Admin/      # AdminDashboard, StaffForm, DoctorsForm, PatientsForm
│       └── Staff/      # StaffDashboard, DoctorForm
├── Models/              # User, AuthUser, Doctor, Patient, StaffMemeber
├── Utils/               # DBCon (connection helper), InputValidator
├── Resources/           # Icons used across forms
├── Create-Tables_SQL.sql
├── App.config
└── DMS_SLN.sln
```

## Getting Started

### Prerequisites

- Windows with Visual Studio 2019+ (or any IDE supporting .NET Framework 4.8 WinForms projects)
- SQL Server / SQL Server Express with the SQL Server client tools

### Setup

1. Clone the repository and open `DentalCare/DMS_SLN.sln` in Visual Studio.
2. Run `Create-Tables_SQL.sql` against your SQL Server instance to create the `Healthcareplus` database and its tables.
3. Update the connection string in `App.config` to point at your SQL Server instance:
   ```xml
   <add name="HealthCare_Plus.Properties.Settings.HealthcareplusConnectionString"
        connectionString="Data Source=YOUR_SERVER;Initial Catalog=HealthCarePlus;Integrated Security=True;TrustServerCertificate=True"
        providerName="System.Data.SqlClient" />
   ```
4. Build and run the solution.

## Known Limitations

- Connection string currently defaults to `localhost\SQLEXPRESS` and must be edited manually for other environments.
- No automated tests are included.

## License

No license file is currently included. Add one (e.g. MIT) if you intend this to be reused by others.

## Author

Tanvir Hasan — Computer Science undergraduate, American International University-Bangladesh (AIUB)
