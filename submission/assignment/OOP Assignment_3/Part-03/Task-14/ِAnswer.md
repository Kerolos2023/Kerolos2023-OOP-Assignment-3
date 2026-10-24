
# Part 03 — Answers

## BlockedUsers

- Time complexity before: O(n * m)
- Time (ms) before: 31 ms
- Found before: 5000

- Time complexity after: O(n + m) expected
- Average time (ms) after: 2.82 ms
- Found after: 5000

- What changed?
  Converted blockedIds from List<int> to HashSet<int> to improve lookup performance.

- Result:
  The found count remained unchanged at 5000. The measured time decreased from 31 ms to an average of 2.82 ms.

## Students

- What was the problem?
  GetAllStudents created and stored 1,000,000 Student objects in a List, even though Program.cs printed only the first 3 students.

- What changed?
  Changed the return type from List<Student> to IEnumerable<Student> and used yield return to generate students lazily.

- Result:
  Program.cs still prints the first 3 students. Because the enumeration stops after 3 students, the remaining students are not created.
