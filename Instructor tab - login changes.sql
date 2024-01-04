Use [University]
Go


--View of usernames + encrypted passwords:
CREATE VIEW v_InstLogins
AS
SELECT Username = i.Username, LoginID = il.LoginID, Password = il.[password]
FROM InstructorLogin il
JOIN Instructor i ON i.Instructor_ID = il.LoginID

--Stored procedure to get password for username if exists - to be called in C#
CREATE PROCEDURE sp_GetEncryptedInstPw

@username varchar(20),
@password varchar(MAX) OUTPUT

AS
BEGIN
	SET @password = (SELECT [Password] FROM v_InstLogins WHERE Username = @username)
END