Use [University]
Go

--Create function to encrypt a varchar(20) password text string
--Returns varchar(max)
--sha2_256 protocol encrypts text
--then it is converted to base-64 so it can be returned and then stored as varchar 

CREATE FUNCTION encryptPw2 
(
	@Pw_chars varchar(20)
)
RETURNS varchar(MAX)

AS

BEGIN
	DECLARE @result varchar(MAX);

	DECLARE @hashedValue VARBINARY(8000) = HASHBYTES('SHA2_256', @Pw_chars);

	SET @result = (
		SELECT CAST(N'' AS XML).value('xs:base64Binary(xs:hexBinary(sql:column("Encrypted")))', 'VARCHAR(MAX)') AS Base64Encoding
		FROM (
		  SELECT @hashedValue AS [Encrypted]
		) AS pw_str
	);

	RETURN @result;
END;

--View of usernames + encrypted passwords:
CREATE VIEW v_UsernamesPasswords
AS
SELECT Username = s.Username, LoginID = sl.LoginID, Password = sl.password
FROM StudentLogin sl
JOIN Student s ON s.Student_ID = sl.LoginID

--Stored procedure to get password for username if exists - to be called in C#
CREATE PROCEDURE sp_GetEncryptedUserPw

@username varchar(20),
@password varchar(MAX) OUTPUT

AS
BEGIN
	SET @password = (SELECT Password FROM v_UsernamesPasswords WHERE Username = @username)
END

--Test stored procedure; result should be EdTdw1fggilo2/0ia24cKqwBjQdqVNpPZeHcgYBoSsM=
DECLARE @outputPassword varchar(MAX)
EXEC sp_GetEncryptedUserPw @username = 'jsmith1', @password = @outputPassword OUTPUT;
SELECT @outputPassword AS test