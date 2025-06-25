class DescendingComparer : IComparer<Student>
{
    public int Compare(Student? student1, Student? student2)
    {
        return -student1.Course.CompareTo(student2?.Course);
    }
}