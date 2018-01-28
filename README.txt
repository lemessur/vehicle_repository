This project was developed in C# using .NET Core 2 (v2.1.4 to be specific)

To run the program from the command line:

dotnet run --project VehicleInventory/VehicleInventory.csproj

Notes:

- Unity is used to demonstrate the use of dependency injection
- No database integration exists since this is intended to be a simple example
	- Data is currently stored only in volatile memory
	- Entity Framework and (any SQL implementation) could be added fairly easily