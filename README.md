# PassDataTableToStoredProcedure
Example App showing how to pass a DataTable to a stored procedure.

The database used is the Northwind sample Db. Besides of having the Northwind db, there's a script that has to be executed to create an user, a db type, a stored procedure and set the permissions.

==========================================================================================================================================

In this version (V1.1) of the solution the DataBase used is the one stored in Azure. And the SQL script was splitted in two files, and must be executed in this order:

01 - Users.sql
02 - Table Stored Procedure.sql
