public class InfoEventArgs
{
    public string PropertyName { get; set; }
    public string ErrorText { get; set; }
    public DateTime ChangedDate { get; set; }

    public InfoEventArgs(string propertyName, string errorText, DateTime changedDate)
    {
        PropertyName = propertyName;
        ErrorText = errorText;
        ChangedDate = changedDate;
    }
}