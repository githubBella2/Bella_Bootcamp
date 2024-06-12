namespace Databaseku.Model;

public class Chat
{
    public int ChatID { get; set; }
    public int DoctorID { get; set; }
    public string Message { get; set; }
    public Doctor Doctor { get; set; }
    public int PatientID { get; set; }
    public Patient Patient { get; set; }
}
