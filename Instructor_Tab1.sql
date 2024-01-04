--Instructors tab 1--

--create view to access courses
-- create vew to access courses

CREATE VIEW v_InstructorCourses AS
SELECT 
	co.Course_ID,
	[Course Title] = co.Course_Title, 
	[Course Code] = concat(d.Code, co.Course_Number), 
	ins.First_Name + ' ' + ins.Last_Name as [Instructor Name], 
	da.Day_Code as [Day], 
	[Time Slot] = concat_ws(' - ', 	FORMAT(Cast(Convert(varchar(15),slo.Start_Time,100) as DateTime), 'hh:mm tt'), FORMAT(Cast(Convert(varchar(15),slo.End_Time,100) as DateTime), 'hh:mm tt')),
	co.PreReqs, 
	co.CoReqs,
	s.Semester_ID,
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
LEFT JOIN Department d ON d.Dept_ID = co.Department

--use already created view v_semester

--SP to get courses given semester season and year (different than GetAvailableCourses because also need the # of registrations

CREATE PROCEDURE SP_GetInstructorAvailableCourses
    @Season VARCHAR(6),
    @Year VARCHAR(4)
AS
BEGIN
	SELECT 
	    DISTINCT [Course Title], 
		[Course Code], 
		[Instructor Name], 
		[Day], 
		[Time Slot], 
		PreReqs, 
		CoReqs,
		[Number of Registrations] = COUNT(co.[Registration Student ID])  -- Use the appropriate column for Student_ID in your Registration table
	FROM 
		v_InstructorCourses co
	WHERE 
		co.Semester_ID = (
			SELECT Semester_ID
			FROM v_semesters
			WHERE Season LIKE @Season AND [Year] = @Year
		) 
	GROUP BY 
		[Course Title], 
		[Course Code], 
		[Instructor Name], 
		[Day], 
		[Time Slot], 
		PreReqs, 
		CoReqs,
		co.[Registration Student ID]
END;

--test SP
EXEC SP_GetInstructorAvailableCourses @Season = 'Spring', @Year = 2021;