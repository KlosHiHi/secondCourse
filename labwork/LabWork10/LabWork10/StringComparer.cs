class StringComparer : IComparer<Student>
{
    public int Compare(Student? student1, Student? student2)
    {
        return student1.FullName.CompareTo(student2?.FullName);
    }
}