namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("=== Student Management System ===\n");

                // Task 1: Working with Dictionaries
                DemonstrateDictionary();

                Console.WriteLine("\n" + new string('-', 40) + "\n");

                // Task 3: Working with Sets
                DemonstrateHashSet();

                Console.WriteLine("\n" + new string('-', 40) + "\n");

                // Task 4: Set Operations
                DemonstrateSetOperations();

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }

            static void DemonstrateDictionary()
            {
                Console.WriteLine("TASK 1: Student Dictionary\n");

                // Create a dictionary with student IDs and names using the provided data
                Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 102, "Thando Funde" },
                { 103, "Lihle Funde" },
                { 104, "Yemvelo Sonka" },
                { 105, "Thando Brown" }
            };

                // Display all students
                Console.WriteLine("Student Directory:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
                }

                // Search for a student by ID
                Console.WriteLine("\nSearching for student with ID 103:");
                if (students.TryGetValue(103, out string studentName))
                {
                    Console.WriteLine($"Found: {studentName}");
                }

                // Add a new student
                students.Add(101, "Lihlethando Funde");
                Console.WriteLine($"\nAdded new student: ID 101, Lihlethando Funde");

                // Display updated dictionary
                Console.WriteLine("\nUpdated Student Directory:");
                foreach (var student in students.OrderBy(s => s.Key))
                {
                    Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
                }

                // Demonstrate searching for a student by name
                Console.WriteLine("\nSearching for students with name 'Thando':");
                var thandoStudents = students.Where(s => s.Value.Contains("Thando"));
                foreach (var student in thandoStudents)
                {
                    Console.WriteLine($"Found: ID {student.Key}, Name: {student.Value}");
                }
            }

            static void DemonstrateHashSet()
            {
                Console.WriteLine("TASK 3: Unique Course Codes\n");

                // Create a HashSet to store unique course codes
                HashSet<string> courseCodes = new HashSet<string>();

                // Add course codes (duplicates will be ignored)
                courseCodes.Add("CS101");
                courseCodes.Add("MATH201");
                courseCodes.Add("PHY301");
                courseCodes.Add("CS101"); // This duplicate will be ignored
                courseCodes.Add("CHEM150");
                courseCodes.Add("MATH201"); // This duplicate will be ignored
                courseCodes.Add("ENG101");
                courseCodes.Add("BIO210");

                // Display unique course codes
                Console.WriteLine("Unique Course Codes:");
                foreach (string code in courseCodes.OrderBy(code => code))
                {
                    Console.WriteLine($"- {code}");
                }

                Console.WriteLine($"\nTotal unique courses: {courseCodes.Count}");

                // Check if specific courses exist
                string[] coursesToCheck = { "PHY301", "HIST101", "MATH201" };
                Console.WriteLine("\nChecking course availability:");
                foreach (string course in coursesToCheck)
                {
                    Console.WriteLine($"Is '{course}' in the set? {courseCodes.Contains(course)}");
                }

                // Remove a course
                courseCodes.Remove("CHEM150");
                Console.WriteLine($"\nAfter removing CHEM150, total courses: {courseCodes.Count}");
            }

            static void DemonstrateSetOperations()
            {
                Console.WriteLine("TASK 4: Set Operations - Math vs Science Classes\n");

                // Create sets for Math and Science classes using the provided student names
                HashSet<string> mathClass = new HashSet<string>
            {
                "Lihlethando Funde",
                "Thando Funde",
                "Lihle Funde",
                "Yemvelo Sonka"
            };

                HashSet<string> scienceClass = new HashSet<string>
            {
                "Thando Funde",
                "Lihle Funde",
                "Thando Brown",
                "Yemvelo Sonka"
            };

                // Display the classes
                Console.WriteLine("Math Class Students:");
                DisplaySet(mathClass);

                Console.WriteLine("\nScience Class Students:");
                DisplaySet(scienceClass);

                // Intersection: Students in both classes
                HashSet<string> bothClasses = new HashSet<string>(mathClass);
                bothClasses.IntersectWith(scienceClass);
                Console.WriteLine("\nStudents in BOTH Math and Science (Intersection):");
                DisplaySet(bothClasses);

                // Difference: Students only in Math
                HashSet<string> onlyMath = new HashSet<string>(mathClass);
                onlyMath.ExceptWith(scienceClass);
                Console.WriteLine("\nStudents ONLY in Math (Difference):");
                DisplaySet(onlyMath);

                // Difference: Students only in Science
                HashSet<string> onlyScience = new HashSet<string>(scienceClass);
                onlyScience.ExceptWith(mathClass);
                Console.WriteLine("\nStudents ONLY in Science (Difference):");
                DisplaySet(onlyScience);

                // Union: All unique students
                HashSet<string> allStudents = new HashSet<string>(mathClass);
                allStudents.UnionWith(scienceClass);
                Console.WriteLine("\nALL Students (Union):");
                DisplaySet(allStudents);

                // Additional operation: Symmetric Difference (students in one class but not both)
                HashSet<string> exclusiveStudents = new HashSet<string>(mathClass);
                exclusiveStudents.SymmetricExceptWith(scienceClass);
                Console.WriteLine("\nStudents in ONLY ONE class (Symmetric Difference):");
                DisplaySet(exclusiveStudents);

                // Additional analysis
                Console.WriteLine("\n=== Class Enrollment Analysis ===");
                Console.WriteLine($"Math class enrollment: {mathClass.Count} students");
                Console.WriteLine($"Science class enrollment: {scienceClass.Count} students");
                Console.WriteLine($"Students taking both subjects: {bothClasses.Count} students");
                Console.WriteLine($"Total unique students across both classes: {allStudents.Count} students");

                double overlapPercentage = (double)bothClasses.Count / mathClass.Count * 100;
                Console.WriteLine($"Overlap: {overlapPercentage:F1}% of Math students also take Science");
            }

            static void DisplaySet(HashSet<string> set)
            {
                if (set.Count == 0)
                {
                    Console.WriteLine("  (No students)");
                    return;
                }

                foreach (string student in set.OrderBy(s => s))
                {
                    Console.WriteLine($"  - {student}");
                }
                Console.WriteLine($"  Total: {set.Count} students");
            }
        }
    }