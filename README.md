#sqlc test project in c# 
Requires sqlc: https://sqlc.dev/
C# plugin can be found at: https://github.com/DaredevilOSS/sqlc-gen-csharp
Additionaly, the project that uses the generated code from sqlc need the nuget package: https://www.nuget.org/packages/SQLitePCLRaw.bundle_e_sqlite3/


Generate the sqlc.yaml file. Additionaly a file for the db schema and the sql queries will need to be created.
For the format of these files see sqlc docs. 
The files need to encoded in utf-8
