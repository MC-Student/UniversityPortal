
# UniversityPortal

BUG FOUN: When pressing cancel on the login page, the logged in page opens regardless. This needs fixing. 

- Work below due Wednesday! See some examples of UI [here](https://docs.google.com/document/d/1LjqK5Fo6xtL95sweyEVIr2FRsDMa_Td999YPmWQpeO4/edit?usp=sharing)
- Review requirements for each tab in student app using [List of reports/apps](https://docs.google.com/document/d/1iLkEf6UJe8XEaxrWop2d4ez3JVAtTNC-8GSqJSv3daE/edit?usp=sharing  "List of reports as of Dec 14")
- Each member of team will branch off to work on assigned tab and create PR on first push
  - `git checkout -b studentInfoTab` - Elky: Add/edit personal information
      - View of student information; use stored procedure to display their information
      - Buttons next to each of the pieces of information that may be changed (major, minor, phone number, address) - when clicked, use the stored procedure associated with that button to UPDATE the field in the table. (after, recall SP to display the updated information)
  - `git checkout -b studentCourseTab` - Libby:
    - View all available courses and information about them
      - View to display all course sections and information about them (class name, code, day(s), start & end times, credits, instructor)
      - Stored procedure to pull from the view only records associated with the selected semester, and ordered based on filters selected (if any): department, start time, and day(s)
      - Button next to each course if can register or if can drop:
        - Register for classes: where student has taken its prereq if exists and if it’s offered in current semester (Use stored procedure in C# as validation)
        - Drop classes: if student is registered for class, then call stored procedure to change grade of that registration record (student id + section id) to W to drop the class
    - Get a course schedule
      - Based on chosen semester from drop down, call stored procedure which pulls from view of all the registration records, for that student, where the section’s semester = chosen semester
      - Button to get line by line schedule for student (Stored procedure to join all student info with section info and grade info, return object with records for specified student and sections of selected semester)
      - Hope to offer button to get calendar schedule also
  - `git checkout -b studentGradeTab` - Meira Tova: View grades, get a transcript
      - Display current courses’ names and codes with current overall grades for a given semester - use stored procedure to pull from view of all registration records (student info + section info + grade)
      - Select start and end semester to obtain transcript; button to get transcript (Stored procedure with start and end semester to get sections’ names and grades)
