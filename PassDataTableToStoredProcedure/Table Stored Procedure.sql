IF EXISTS (SELECT * FROM sys.sysusers WHERE name = N'dbuser') 
	DROP USER dbuser
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

CREATE PROCEDURE dbo.SP_CustomerList
@CustomerList AS CustomerTable READONLY

AS
BEGIN
    SELECT C.CustomerName, C01.*
	FROM @CustomerList C
	INNER JOIN dbo.Customers C01 ON C.CustomerId = C01.CustomerId
END
GO

GRANT EXEC ON TYPE::[dbo].[CustomerTable] TO [dbuser]
GO

GRANT EXECUTE ON dbo.SP_CustomerList TO dbuser
GO


DECLARE @CustomerList AS CustomerTable

INSERT INTO @CustomerList VALUES ('ALFKI', 'Juan Vargas')
INSERT INTO @CustomerList VALUES ('CHOPS', 'Acacia Cuevas')
 

EXECUTE dbo.SP_CustomerList @CustomerList
GO