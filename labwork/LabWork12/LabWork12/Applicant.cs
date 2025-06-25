record Applicant
{
    public string fullName;
    public int grade;
    public double averageScore;

    public Applicant() 
        : this("unknown", 0, 0) { }

    public Applicant(string fullName, int grade, double averageScore)
    {
        this.fullName = fullName;
        this.grade = grade;
        this.averageScore = averageScore;
    }
}
