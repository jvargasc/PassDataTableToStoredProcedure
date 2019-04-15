IF EXISTS (SELECT * FROM sys.sql_logins WHERE name = N'dbuser')
	DROP LOGIN dbuser
GO

CREATE LOGIN dbuser WITH PASSWORD = 'P4$$w0rd'
GO
