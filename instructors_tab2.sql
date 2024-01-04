--Instructors tab 2--
ALTER VIEW v_InstructorStudentView AS
SELECT
	[Student ID Number] = stu.Student_ID,
    [Name] = ISNULL(stu.First_Name, '') + ' ' + ISNULL(stu.Last_Name, ''),
    [Major] = ISNULL(ma.Major_Name, 'N/A'),
    [Minor] = ISNULL(mi.Minor_Name, 'N/A'),
    [Honors] = (CASE WHEN hon.Honors_Status = 'N/A' THEN 'Unknown' WHEN hon.Honors_Status = '0' THEN 'No' WHEN hon.Honors_Status = '1' THEN 'Yes' ELSE ' ' END),
    [Year_Status] = ISNULL(st.Year_Status, 'N/A'),
	[Course Title] = co.Course_Title,
	[Grade] = gr.Letter_Grade,
	[Season] = sem.Season,
	[Year] = sem.[Year]
FROM
    Student AS stu
    LEFT JOIN Major AS ma ON stu.Major_ID = ma.Major_ID
    LEFT JOIN Minor AS mi ON stu.Minor_ID = mi.Minor_ID
    LEFT JOIN Honors AS hon ON stu.Honors_ID = hon.Honors_ID
    LEFT JOIN Student_Status AS st ON stu.Status_ID = st.Status_ID
	JOIN Course co ON co.Course_ID = stu.Student_ID
	JOIN Registration re ON co.Course_ID = re.Section_ID
	LEFT JOIN Section sect ON sect.Section_ID = re.Section_ID
	JOIN Grade gr ON gr.Grade_ID = re.Grade_ID
	FULL JOIN Semester sem ON sem.Semester_ID = sect.Semester_ID

	GO
--SP to get the info given the current instructor
ALTER PROCEDURE SP_InstructorStudentInfo
@InstructorUsername VARCHAR(20),
@Season varchar(10),
@Year varchar(10)
AS
BEGIN
	SELECT 
		[Name],
		Major,
		Minor,
		Honors,
		[Year_Status],
		[Course Title],
		[Grade]
	FROM v_InstructorStudentView v
	JOIN Registration re ON re.Student_ID = v.[Student ID Number]
	JOIN Section sec ON sec.Section_ID = re.Section_ID
	JOIN Instructor ins ON ins.Instructor_ID = sec.Instructor_ID
	WHERE ins.Username = @InstructorUsername AND v.Season = @Season AND v.[Year] = @Year
END;
GO
--SP to set the new Grade given a specific user
CREATE PROCEDURE SP_InstructorSetGrade
	@SectionId INT,
	@StudentId INT,
	@GradeID INT
AS
BEGIN
	UPDATE dbo.Registration
	SET Grade_ID = @GradeID
	WHERE Section_ID = @SectionId
		AND Student_ID = @StudentId;
END;