--view of all registration records (student info + section info + grade)

CREATE VIEW v_Registration
AS
SELECT	[Username] = s.Username,
		[Time] = s.[Timestamp],
		[First Name] = s.First_Name, 
		[Middle Name] = s.Middle_Name,
		[Last Name] = s.Last_Name,
		[Date of Birth] = s.DOB,
		[Major] = mj.Major_Name,
		[Minor] = mn.Minor_Name,
		[Honors Student] = h.Honors_Status,
		[Course Code] = concat(d.Code, c.Course_Number),
		[Course Title] = c.Course_Title,
		[Season] = sem.Season,
		[Year] = sem.[Year],
		[Instructor] = concat_ws(' ', i.Instructor_Title, i.First_Name, i.Last_Name),
		[Grade] = g.Letter_Grade

FROM Registration r
LEFT JOIN Student s ON s.Student_ID = r.Student_ID
LEFT JOIN Section sect ON sect.Section_ID = r.Section_ID
LEFT JOIN Grade g ON g.Grade_ID = r.Grade_ID
LEFT JOIN Major mj ON mj.Major_ID = s.Major_ID --
LEFT JOIN Minor mn ON mn.Minor_ID = s.Minor_ID --
FULL JOIN Honors h ON h.Honors_ID = s.Honors_ID
LEFT JOIN Course c ON c.Course_ID = sect.Course_ID --
FULL JOIN Semester sem ON sem.Semester_ID = sect.Semester_ID
FULL JOIN Instructor i ON i.Instructor_ID = sect.Instructor_ID
LEFT JOIN Department d ON d.Dept_ID = c.Department

GO
select * from v_Registration
GO

CREATE PROCEDURE sp_GetSemesterGrades
@Season varchar(10),
@Year varchar(10),
@Username varchar(25)
AS
BEGIN
	SELECT [Course Code], [Course Title], Grade
	FROM v_Registration
	WHERE Username = @Username AND Season = @Season AND [Year] = @Year
END

/*SELECT [Course Code], [Course Title], Grade
	FROM v_Registration
	WHERE Username = 'jsmith1' AND Season = 'Spring' AND [Year] = '2020'*/
GO

CREATE PROCEDURE sp_GetTranscriptInfo
@StartSeason varchar(10),
@StartYear varchar(10),
@EndSeason varchar(10),
@EndYear varchar(10),
@Username varchar(25)
AS
BEGIN
	IF ((@StartYear = @EndYear) OR ((CAST(@EndYear AS int) - CAST(@StartYear AS int) = 1) AND (@StartSeason = 'Fall' AND @EndSeason = 'Spring')))
		BEGIN
			SELECT [Semester] = concat_ws(' ', Season, [Year]), [Course Code], [Course Title], [Grade]
			FROM v_Registration
			WHERE Username = @Username AND ((Season = @StartSeason AND [Year] = @StartYear) OR (Season = @EndSeason AND [Year] = @EndYear))
			ORDER BY [Year]
		END
	ELSE IF (CAST(@EndYear AS int) - CAST(@StartYear AS int) = 1)
			IF(@StartSeason = @EndSeason)
				BEGIN
					DECLARE @MidYear varchar(10)
					IF @StartSeason = 'Fall'
						SET @MidYear = @EndYear
					ELSE
						SET @MidYear = @StartYear

					SELECT [Semester] = concat_ws(' ', Season, [Year]), [Course Code], [Course Title], [Grade]
					FROM v_Registration
					WHERE Username = @Username AND ((Season = @StartSeason AND [Year] = @StartYear) 
													OR (Season = @EndSeason AND [Year] = @EndYear)
													OR (Season <> @StartSeason AND [Year] = @MidYear))
					ORDER BY [Year]
				END
			ELSE 
				IF (@StartSeason = 'Spring' AND @EndSeason= 'Fall')
					BEGIN
						SELECT [Semester] = concat_ws(' ', Season, [Year]), [Course Code], [Course Title], [Grade]
						FROM v_Registration
						WHERE Username = @Username AND ((Season = @StartSeason AND [Year] = @StartYear) 
														OR (Season = @EndSeason AND [Year] = @EndYear)
														OR (Season = @StartSeason AND [Year] = @EndYear)
														OR (Season = @EndSeason AND [Year] = @StartYear))
						ORDER BY [Year]
					END
END

select * from v_Registration

EXEC sp_GetTranscriptInfo
    @StartSeason = 'Spring',
    @StartYear = '2020',
    @EndSeason = 'Fall',
    @EndYear = '2021',
    @Username = 'jsmith1';

/*DECLARE @StartSeason varchar(10),
 @StartYear varchar(10),
 @EndSeason varchar(10),
 @EndYear varchar(10),
 @Username varchar(25)

SET @StartSeason = 'Spring'
SET @StartSeason = '2020'
SET @EndSeason = 'Fall'
SET @EndYear = '2021'
SET @Username = 'jsmith1'

IF ((@StartYear = @EndYear) OR ((CAST(@EndYear AS int)- CAST(@StartYear AS int) = 1) AND (@StartSeason = 'Fall' AND @EndSeason = 'Spring')))
		BEGIN
			SELECT [Semester] = concat_ws(' ', Season, [Year]), [Course Code], [Course Title], [Grade]
			FROM v_Registration
			WHERE Username = @Username AND ((Season = @StartSeason AND [Year] = @StartYear) OR (Season = @EndSeason AND [Year] = @EndYear))
			ORDER BY [Year]
		END
	ELSE
		IF (CAST(@EndYear as int) - CAST(@StartYear as int) = 1)
			IF(@StartSeason = @EndSeason)
				BEGIN
					DECLARE @MidYear varchar(10)
					IF @StartSeason = 'Fall'
						SET @MidYear = @EndYear
					ELSE
						SET @MidYear = @StartYear

					SELECT [Semester] = concat_ws(' ', Season, [Year]), [Course Code], [Course Title], [Grade]
					FROM v_Registration
					WHERE Username = @Username AND ((Season = @StartSeason AND [Year] = @StartYear) 
													OR (Season = @EndSeason AND [Year] = @EndYear)
													OR (Season <> @StartSeason AND [Year] = @MidYear))
					ORDER BY [Year]
				END
			ELSE 
				IF (@StartSeason = 'Spring' AND @EndSeason= 'Fall')
					BEGIN
						SELECT [Semester] = concat_ws(' ', Season, [Year]), [Course Code], [Course Title], [Grade]
						FROM v_Registration
						WHERE Username = @Username AND ((Season = @StartSeason AND [Year] = @StartYear) 
														OR (Season = @EndSeason AND [Year] = @EndYear)
														OR (Season = @StartSeason AND [Year] = @EndYear)
														OR (Season = @EndSeason AND [Year] = @StartYear))
						ORDER BY [Year]
					END
					*/