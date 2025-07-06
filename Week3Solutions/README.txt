# Week 3 – Entity Framework Core 8.0 Hands-On Exercises

This repository contains hands-on lab solutions for EF Core 8.0 using a Retail Inventory Management scenario.

## Setup

- .NET SDK 9.0+
- Visual Studio or VS Code
- SQL Server + SSMS
- EF Core CLI (`dotnet-ef`)

## Project Structure

- `RetailInventory/` – Console app for Labs 3, 4, and 5.
- `output/` – Screenshots of migration, data insertion, and retrieval.
- `README.md` – This file.

---

## Lab Overview

### Lab 1: What is ORM?

> ORM helps map C# classes to SQL tables using EF Core.  
> Benefits: Productivity, maintainability, abstraction from SQL.

### Lab 2: Setting Up `DbContext`

- Created models: `Category` and `Product`.
- Created `AppDbContext` class with SQL Server connection.

### Lab 3: EF CLI Migrations

- Used EF Core CLI to:
  - Generate migration
  - Apply migration
  - Create database

### Lab 4: Insert Initial Data

- Added sample categories: Electronics, Groceries
- Added sample products: Laptop, Rice Bag

### Lab 5: Retrieve Data

- Displayed all products with price
- Found product by ID and conditionally by price

---

## Output

Screenshots of each step are inside the `output/` folder.

---

## Author

Sai Talluri – CSE, B.Tech (3rd Year)
