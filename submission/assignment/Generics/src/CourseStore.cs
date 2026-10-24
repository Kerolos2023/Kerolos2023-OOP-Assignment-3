using System.Collections.Generic;
public class CourseStore
{
    private readonly List<Course> courses = new List<Course>();

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public Course? GetById(int id)
    {
        foreach (Course course in courses)
        {
            if (course.Id == id)
            {
                return course;
            }
        }

        return null;
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Remove(int id)
    {
        Course? course = GetById(id);

        if (course != null)
        {
            courses.Remove(course);
        }
    }
}
