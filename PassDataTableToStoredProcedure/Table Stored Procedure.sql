USE Northwind
GO

IF EXISTS (SELECT * FROM sys.sql_logins WHERE name = N'dbuser')
	DROP LOGIN [dbuser]
GO

IF EXISTS (SELECT * FROM sys.sysusers WHERE name = N'dbuser') 
	DROP USER [dbuser]
GO

CREATE LOGIN dbuser WITH PASSWORD = 'P4$$w0rd'
GO

CREATE USER dbuser FOR LOGIN dbuser WITH DEFAULT_SCHEMA = dbo
GO

IF EXISTS ( SELECT * 
            FROM sysobjects 
            WHERE id = object_id(N'[dbo].[SP_CustomerList]') 
		  )
    DROP PROCEDURE [dbo].[SP_CustomerList]

IF TYPE_ID('[dbo].[CustomerTable]') IS NOT NULL
        DROP TYPE [dbo].[CustomerTable];

CREATE TYPE dbo.CustomerTable AS TABLE
(
    CustomerId nchar(5) primary key,
    CustomerName nvarchar(50)
)
GO

GRANT EXEC ON TYPE::[dbo].CustomerTable TO dbuser
GO

CREATE PROCEDURE dbo.SP_CustomerList
@CustomerList AS CustomerTable READONLY

AS
BEGIN
    SELECT C.CustomerName, C01.*
	FROM @CustomerList C
	INNER JOIN dbo.Customers C01 ON C.CustomerId = C01.CustomerId
END
GO

GRANT EXECUTE ON OBJECT::dbo.SP_CustomerList
    TO dbuser;  
GO

DECLARE @CustomerList AS CustomerTable
 
INSERT INTO @CustomerList VALUES ('ALFKI', 'Juan Vargas')
INSERT INTO @CustomerList VALUES ('CHOPS', 'Acacia Cuevas')
 

EXECUTE dbo.SP_CustomerList @CustomerList
GO