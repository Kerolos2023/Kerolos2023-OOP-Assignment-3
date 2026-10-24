public class StudentStore
{
    private readonly List<Student> students = new List<Student>();

    public void Add(Student student)
    {
        students.Add(student);
    }

    public Student? GetById(int id)
    {
        foreach (Student student in students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }

        return null;
    }

    public List<Student> GetAll()
    {
        return students;
    }

    public void Remove(int id)
    {
        Student? student = GetById(id);

        if (student != null)
        {
            students.Remove(student);
        }
    }
}
