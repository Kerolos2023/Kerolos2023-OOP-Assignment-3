
using System;
using System.Collections.Generic;

// 1. Create a Store<Student> and add 5 students
Store<Student> studentStore = new Store<Student>();

studentStore.Add(new Student(1, "Ahmed"));
studentStore.Add(new Student(2, "Mina"));
studentStore.Add(new Student(3, "Kerolos"));
studentStore.Add(new Student(4, "Ali"));
studentStore.Add(new Student(5, "Omar"));

// 2. Create a Store<Course> and add 3 courses
Store<Course> courseStore = new Store<Course>();

courseStore.Add(new Course(101, "C#", 1500m));
courseStore.Add(new Course(102, "OOP", 1200m));
courseStore.Add(new Course(103, "SQL", 1000m));

// 3. Get one student and one course by ID
Console.WriteLine("=== Get By ID ===");

Student? student = studentStore.GetById(3);
Console.WriteLine(student is not null
    ? $"Student: {student.Id} - {student.Name}"
    : "Student not found");

Course? course = courseStore.GetById(102);
Console.WriteLine(course is not null
    ? $"Course: {course.Id} - {course.Title} - {course.Price}"
    : "Course not found");

// 4. Add a student with a duplicate ID
Console.WriteLine("\n=== Duplicate ID ===");

try
{
    studentStore.Add(new Student(3, "Duplicate Student"));
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

// 5. Print page 2 of students, page size = 2
Console.WriteLine("\n=== Students: Page 2 (Size 2) ===");

foreach (Student item in studentStore.GetAll().Page(2, 2))
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}

// 6. Call FindById on a plain List<Course>
Console.WriteLine("\n=== Find Course By ID ===");

List<Course> courses = new List<Course>
{
    new Course(201, "HTML", 500m),
    new Course(202, "CSS", 600m),
    new Course(203, "JavaScript", 900m)
};

Course? foundCourse = courses.FindById(202);

Console.WriteLine(foundCourse is not null
    ? $"Found: {foundCourse.Id} - {foundCourse.Title}"
    : "Course not found");

// must NOT compile
// Store<string> stringStore = new Store<string>();
