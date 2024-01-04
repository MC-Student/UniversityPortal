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

--Populate encrypted passwords (associated with usernames)

INSERT INTO StudentLogin(LoginID, [password]) VALUES (1, dbo.encryptPw2('helloWorld'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (2, dbo.encryptPw2('FootballFan'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (3, dbo.encryptPw2('College21!'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (4, dbo.encryptPw2('StudyHard19'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (5, dbo.encryptPw2('Coffee&Code'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (6, dbo.encryptPw2('CampusLife22'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (7, dbo.encryptPw2('PassTheExam'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (8, dbo.encryptPw2('BookWorm2023'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (9, dbo.encryptPw2('PizzaLover'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (10, dbo.encryptPw2('1234College'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (11, dbo.encryptPw2('SpringBreak!'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (12, dbo.encryptPw2('CoolStudent'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (13, dbo.encryptPw2('LateNights'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (14, dbo.encryptPw2('EssayTime20'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (15, dbo.encryptPw2('StarGazer17'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (16, dbo.encryptPw2('TechGeek123'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (17, dbo.encryptPw2('Sun&Sand2022'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (18, dbo.encryptPw2('SmartMind18'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (19, dbo.encryptPw2('GroupProject'));
INSERT INTO StudentLogin(LoginID, [password]) VALUES (20, dbo.encryptPw2('EasyA2024'));

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