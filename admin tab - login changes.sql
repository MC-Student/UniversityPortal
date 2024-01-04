CREATE VIEW v_AdminLogins
AS
SELECT Username = a.Username, LoginID = al.LoginID, Password = al.[password]
FROM AdministratorLogin al
JOIN Administrator a ON a.Admin_ID = al.LoginID

--Stored procedure to get password for username if exists - to be called in C#
CREATE PROCEDURE sp_GetEncryptedAdminPw

@username varchar(20),
@password varchar(MAX) OUTPUT

AS
BEGIN
	SET @password = (SELECT [Password] FROM v_AdminLogins WHERE Username = @username)
END