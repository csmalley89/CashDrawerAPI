To get this running everyday paste the following in terminal
1. cd workspace/CashDrawerAPI
2. export CashDrawer_Db_Path="/Users/csmalley/workspace/capstone/CashDrawerAPI/CashDrawerDb.db"
3. dotnet ef database update 
4. dotnet run
5. If you have to delete migrations, enter the following: dotnet ef migrations add initialCreate