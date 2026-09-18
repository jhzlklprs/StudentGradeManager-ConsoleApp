# StudentGradeManager-ConsoleApp-
A single console program that manages a small list of students and their grades — simple enough to be beginner-friendly, but with enough moving parts to touch nearly everything on your list.


What it needs to use (mapped to your checklist)
Variables, data types, operators — throughout
If/else, switch — for menu routing and validation
Loops — the main menu loop, plus loops over student data
Methods, parameters, return values — one method per feature
Arrays or List<T> — storing students
Dictionary<TKey,TValue> — mapping student name → grade (or list of grades)
Foreach — displaying all students
Delegates / Action / Func — at least one lookup or validation step done via a delegate, like your calculator
Lambda expressions — at least one Func used as a lambda
Events — trigger a notification when a grade is added (e.g. "grade recorded" event) — ties directly into what you built earlier
Exception handling — try/catch around user input parsing
(Skip enums/structs/nullable — not required, but feel free to sneak int? in somewhere if you want extra practice)

Stage 1 — Beginner: Core loop + basic CRUD

Show a menu:
   1. Add student
   2. View all students
   3. Update a grade
   4. Delete a student
   5. Exit
Use a while loop to keep showing the menu until the user picks Exit.
Use switch to route the menu choice.
Store students in a Dictionary<string, int> — name → grade.
"Add student" should ask for a name and grade, then add to the dictionary.
"View all students" should foreach through the dictionary and print each entry.

Stage 2 — Intermediate: validation + safety
7. Wrap grade input parsing in try/catch (or int.TryParse) so typing letters instead of a number doesn't crash the app.
8. Before adding a student, check ContainsKey so you don't accidentally overwrite an existing student without warning — ask "Student exists, overwrite? y/n".
9. "Update a grade" and "Delete a student" should check the name exists first (ContainsKey/TryGetValue) and print a friendly message if not found — same pattern as your calculator's invalid operator check.

Stage 3 — Intermediate/mid: methods + delegates
10. Refactor every menu action into its own method (AddStudent(), ViewStudents(), etc.) — Main should basically just be the loop + switch calling methods, nothing else.
11. Add a method string GetLetterGrade(int score) that converts a numeric grade to a letter (A/B/C/D/F) using if/else or switch — call this from "View all students" so it prints both.
12. Add a Func<int,int,int> (or similar) somewhere meaningful — e.g. a lambda that calculates the class average, passed into a helper method, or a Func<int,string> version of GetLetterGrade written as a lambda instead of a regular method.

Stage 4 — Mid: events
13. Declare a simple event, e.g. event Action<string> GradeAdded;
14. Subscribe a handler in Main that prints "[Notice] Grade recorded for {name}" whenever a grade is added or updated.
15. Raise (invoke) that event inside your AddStudent/UpdateGrade methods.

Stretch (optional, mid-to-upper):
16. Add a "Class Statistics" menu option: highest grade, lowest grade, and average — using a loop or LINQ-style manual aggregation (don't use actual LINQ yet, that's a later topic — just loops).
17. Sort students by grade before displaying (you can look up List.Sort or OrderBy — flagging that OrderBy specifically is real LINQ, so if you stumble on it now, that's fine, just know it's a preview of a later topic).

Why this order

Each stage is runnable and testable on its own — you're never stuck debugging four new concepts at once. Stage 1 alone would already prove out your fundamentals + collections. By Stage 4 you've deliberately hit every unchecked-but-completed box on your list, including reusing the exact TryParse/ContainsKey patterns we just drilled into with the calculator and traffic light exercises.
