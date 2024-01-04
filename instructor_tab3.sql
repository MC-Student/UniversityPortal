--instructor tab 3--

SELECT * FROM Section

--Create view for section Info
CREATE VIEW v_InstructorSectionView AS
SELECT 
	co.Course_ID,
	[Course Title] = co.Course_Title, 
	co.Course_Number, 
	ins.First_Name + ' ' + ins.Last_Name as [Instructor Name], 
	da.Day_Code as [Day], 
	slo.Start_Time, 
	slo.End_Time, 
	s.Semester_ID,
	sec.Section_ID as [Section ID],
	gr.Letter_Grade as [Letter Grade],
	sec.Instructor_ID as [Section Instructor ID],
	[Registration Section ID] = re.Section_ID,
	[Registration Student ID] = re.Student_ID,
	[Registration Grade ID] = re.Grade_ID
FROM Section sec
JOIN Course co ON sec.Course_ID = co.Course_ID
JOIN Semester se ON se.Semester_ID = sec.Semester_ID
JOIN Instructor ins ON ins.Instructor_ID = sec.Instructor_ID
JOIN Slot slo ON slo.Slot_ID = sec.Slot_ID
JOIN [Day] da ON da.Day_ID = slo.Day_ID
JOIN Semester s ON sec.Semester_ID = s.Semester_ID
JOIN Registration re ON sec.Section_ID = re.Section_ID
JOIN Grade gr ON re.Grade_ID = gr.Grade_ID

--Based on chosen semester from drop down, 
--call stored procedure which pulls from InstructorSectionView 
--and also calculates additional values for each section 
--(historical class average, current class average, number of students), 
--where the instructor is the instructor listed (parameter), and where the section’s semester = chosen semester
CREATE PROCEDURE SP_InstructorSectionInfo
    @InstructorFirstName VARCHAR(20),
    @InstructorLastName VARCHAR(20),
    @SemesterSeason VARCHAR(6),
    @SemesterYear VARCHAR(4)
AS
BEGIN
    SELECT 
        inSec.[Course Title],
        inSec.[Instructor Name],
        inSec.Semester_ID,
        inSec.[Day],
        inSec.Start_Time,
        inSec.End_Time,
        COUNT(DISTINCT inSec.[Registration Student ID]) as [Number of Students]
    FROM v_InstructorSectionView inSec
    JOIN Instructor ins ON ins.Instructor_ID = inSec.[Section Instructor ID]
    WHERE ins.First_Name LIKE @InstructorFirstName AND ins.Last_Name LIKE @InstructorLastName
    AND inSec.Semester_ID = (
        SELECT Semester_ID
        FROM v_semesters
        WHERE Season LIKE @SemesterSeason AND [Year] = @SemesterYear
    )
    GROUP BY 
        inSec.[Course Title],
        inSec.[Instructor Name],
        inSec.Semester_ID,
        inSec.[Day],
        inSec.Start_Time,
        inSec.End_Time
END;

SELECT * FROM Registration
SELECT * FROM Course
SELECT * FROM Section
SELECT * FROM Semester
SELECT * FROM Instructor