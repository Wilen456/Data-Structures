/************************************************************/
/*                                                          */
/*  Class: MATH 626 - Data Structures and Algorithms        */
/*                                                          */
/*  Program: Unit1Smp1.cs                                   */
/*                                                          */
/*  Programmer: Dr. Thuong                                  */
/*                                                          */
/*  Purpose: Implement automated grade report from          */
/*           data file                                      */
/*                                                          */
/************************************************************/

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Unit1Smp1
{
    class Unit1Smp1
    {
        // Define input/output files
        const string DATA_FILE_NAME = "RawGrades.txt";
        const string REPORT_FILE_NAME = "GradeReport.txt";
       
        static StreamReader fileIn;
        static StreamWriter fileOut;

        
        static int numOfStudents;
        static int numOfClassDays;


        // Arrays below store raw grades
        static string[] lastNameArray;
        static string[] firstNameArray;
        static double[,] gradeArray;
        static int[,] attendanceArray;

        // Attendance information
        static int absenceThreshold;
        static double attendanceBonus;

        // Arrays below store calculated grade totals

        static double[] percentArray;
        static string[] letterGradeArray;
        static int[] absencesArray;
        static bool[] bonusArray;


        // Main entry point into the application
        static void Main()
        {
            IdentifyApplication();
            GetAttendanceInput();
            ParseDataFile();
            ProcessGrades();
            PrintResults();
        }

        static void IdentifyApplication()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine("  Application: Unit1Smp1 - Automated grade report");
            Console.WriteLine();
            Console.WriteLine("  ******************************************************************\n");
        }

        static void GetAttendanceInput()
        {
            Console.WriteLine();
            Console.Write("What is the threshold (maximum absences) for the attendance bonus? ");
            
            absenceThreshold = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("What is the percent bonus for {0} or fewer absences? ", absenceThreshold);

            attendanceBonus = Double.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        static void ParseDataFile()
        {
            string lineIn;
            string[] words;
            
            int i, j, k;

            fileIn = File.OpenText(DATA_FILE_NAME);

            fileIn.ReadLine();

            //Because fileIn returns a string, first must parse it to an integer value.
            numOfStudents = Int32.Parse(fileIn.ReadLine());

            fileIn.ReadLine();

            numOfClassDays = Int32.Parse(fileIn.ReadLine());

            fileIn.ReadLine();

            // initialize arrays

            lastNameArray = new string[numOfStudents ];
            firstNameArray = new string[numOfStudents];
            gradeArray = new double[numOfStudents, 5];
            attendanceArray = new int[numOfStudents, numOfClassDays];

            // load arrays with data
            for (i = 0; i < numOfStudents; i++)
            {
                lineIn = fileIn.ReadLine();
                lineIn = lineIn.Trim();
                while (Regex.IsMatch(lineIn, " "))
                {
                    lineIn = lineIn.Replace(" ", "");
                }
                words = lineIn.Split(',');

                lastNameArray[i] = words[0];
                firstNameArray[i] = words[1];

                for(j = 0; j < 5; j++)
                {
                    gradeArray[i, j] = Double.Parse(words[2 + j]);
                }


                for (k = 0; k < numOfClassDays; k++)
                {
                    attendanceArray[i, k] = Int32.Parse(words[7 + k]);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Grade data read from file " + DATA_FILE_NAME);

            fileIn.Close();
        }

        static void ProcessGrades()
        {
            int i, j, k;
            int absences;
            double total;

            absencesArray = new int[numOfStudents];
            percentArray = new double[numOfStudents];
            letterGradeArray = new string[numOfStudents];
            bonusArray = new bool[numOfStudents];

            for(i = 0; i < numOfStudents; i++)
            {
                total = 0;
                absences = 0;

                for (j = 0; j < 5; j++)
                {
                    total += gradeArray[i, j];
                }
                percentArray[i] = (total / 600.0);

        
                for (k = 0; k < numOfClassDays; k++)
                {
                    if (attendanceArray[i, k] == 0)
                    {

                        absences++;
                    }

                }
                absencesArray[i] = absences;


                if (absencesArray[i] <= absenceThreshold)
                {
                   bonusArray[i] = true;
                }

                if (bonusArray[i])
                {
                    percentArray[i] += attendanceBonus / 100;
                }


                if (percentArray[i] >= .8950)
                {
                    letterGradeArray[i] = "A";
                }
                else if (percentArray[i] < .8950 & percentArray[i] >= .7950)
                {
                    letterGradeArray[i] = "B";
                }
                else if (percentArray[i] < .7950 & percentArray[i] >= .6950)
                {
                    letterGradeArray[i] = "C";
                }
                else if (percentArray[i] < .6950 & percentArray[i] >= .5950)
                {
                    letterGradeArray[i] = "D";
                }
                else
                {
                    letterGradeArray[i] = "F";
                }
            }
        }

        static void PrintResults()
        {
            int i;

            fileOut = new StreamWriter(REPORT_FILE_NAME);

            fileOut.WriteLine("Grade Report");
            fileOut.WriteLine("*******************************************************");
            fileOut.WriteLine();
            fileOut.WriteLine("Number of students: {0}", numOfStudents);
            fileOut.WriteLine("Number of class days: {0}", numOfClassDays);
            fileOut.WriteLine();
            fileOut.WriteLine("If a student had {0} or fewer absences, a bonus of {1}%", absenceThreshold, attendanceBonus);
            fileOut.WriteLine("was applied to the final percentage.");
            fileOut.WriteLine();
            fileOut.WriteLine("*******************************************************");
            fileOut.WriteLine();
            fileOut.WriteLine("Last Name,  First Name  Percent  Absences  Grade  Bonus");
            fileOut.WriteLine("*******************************************************");

            for (i = 0; i < numOfStudents; i++)
            {
                fileOut.WriteLine("{0,10}, {1,10}   {2:P2} {3,9}  {4,4} {5,7}", lastNameArray[i], firstNameArray[i], percentArray[i], absencesArray[i], letterGradeArray[i], bonusArray[i]);
            }

            fileOut.Close();

            Console.WriteLine();
            Console.WriteLine("Grade report written to " + REPORT_FILE_NAME);
        }
    }
}