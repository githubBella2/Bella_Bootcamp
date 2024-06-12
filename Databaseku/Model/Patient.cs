namespace Databaseku.Model;

public class Patient
{
    public int PatientID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public IEnumerable<Doctor> Doctor {get;set;}
}
