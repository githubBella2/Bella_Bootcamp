namespace Databaseku.Model;

public class Doctor
{
    public int DoctorID { get; set; }
    public string FullName { get; set; }
    public string? Specialist { get; set; }
    public IEnumerable<Patient> Patients { get; set; }
    public Specialist SpecialistItem { get; set; }
    public int? SpecialistID { get; set; }
}
