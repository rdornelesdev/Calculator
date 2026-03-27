# 🧮 Calculator CLI - C# .NET

A robust Command Line Interface (CLI) calculator built with **C# 12** and **.NET 8**. This project focuses on implementing modern C# features, clean code practices, and defensive programming.

## 🚀 Key Features

* **Modern Switch Expressions**: Using the latest C# syntax for cleaner logic.
* **Defensive Programming**: Robust input validation using `int.TryParse` with `out` parameters.
* **Custom Error Handling**: Specific exceptions for Division by Zero and Invalid Operators.
* **Fail-Fast Principle**: Validation logic that prevents invalid data from propagating through the system.

## 🛠️ Tech Stack

* **Language:** C#
* **Runtime:** .NET 8.0
* **Architecture:** Console Application 

## 🏗️ How it Works

The project is structured to separate concerns between user input and mathematical logic:

1.  **Input Validation**: A dedicated `ValidateAndParse` method ensures only valid integers proceed.
2.  **Calculation Engine**: A `switch expression` handles operations (+, -, *, /) with built-in protection against math errors.
