int examAssignments = 5;
string studentLetterGrade = "";
 
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };
 
int[] sophiaGrades = { 90, 86, 87, 98, 100, 91, 95};
int[] andrewGrades = { 92, 89, 81, 96, 90 };
int[] emmaGrades = { 90, 85, 87, 98, 68, 91 };
int[] loganGrades = { 90, 95, 87, 88, 96 };

decimal[] examScores = { 92.2m, 89.6m, 85.6m, 91.2m };
decimal overallGrade = 0;
int extraCredit = 0;

int[] studentGrades = new int[10];
int i = 0;
 
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string studentName in studentNames)
{
    decimal totalExtraCredit = 0;

    decimal examScore = examScores[i];
    i++;
    if (studentName == "Sophia")
        studentGrades = sophiaGrades;
    else if (studentName == "Andrew")
        studentGrades = andrewGrades;
    else if (studentName == "Emma")
        studentGrades = emmaGrades;
    else if (studentName == "Logan")
        studentGrades = loganGrades;

    int sumAssignmentGrades = 0;
    decimal studentAvgGrade = 0;
    int gradedAssignments = 0;


    foreach (int grade in studentGrades)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentGrades += grade;
        else
        {
            extraCredit = grade / 10;
            sumAssignmentGrades += extraCredit;
            totalExtraCredit += extraCredit;
        }
    }

    studentAvgGrade = (decimal)(sumAssignmentGrades) / examAssignments;
    if (studentAvgGrade >= 97)
        studentLetterGrade = "A+";
    else if (studentAvgGrade >= 93)
        studentLetterGrade = "A";
    else if (studentAvgGrade >= 90)
        studentLetterGrade = "A-";
    else if (studentAvgGrade >= 87)
        studentLetterGrade = "B+";
    else if (studentAvgGrade >= 83)
        studentLetterGrade = "B";
    else if (studentAvgGrade >= 80)
        studentLetterGrade = "B-";
    else if (studentAvgGrade >= 77)
        studentLetterGrade = "C+";
    else if (studentAvgGrade >= 73)
        studentLetterGrade = "C";
    else if (studentAvgGrade >= 70)
        studentLetterGrade = "C-";
    else if (studentAvgGrade >= 67)
        studentLetterGrade = "D+";
    else if (studentAvgGrade >= 63)
        studentLetterGrade = "D";
    else if (studentAvgGrade >= 60)
        studentLetterGrade = "D-";
    else
        studentLetterGrade = "F";

    overallGrade = (studentAvgGrade*.7m) + (examScore*.3m);
    //Console.WriteLine($"{studentName}:\t\t{studentAvgGrade}\t{studentLetterGrade}");
    Console.WriteLine($"{studentName}\t\t{examScore}\t\t{overallGrade}   {studentLetterGrade}\t\t{totalExtraCredit}");
        }
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();