using System.ComponentModel.DataAnnotations.Schema;

[Table("DoctorPatient")]
public class DoctorPatient
{
    public int DoctorID {get;set;}
    public int PatientID {get;set;}
    
    [Column(TypeName = "TEXT")]
    public string MedicalRecord { get; set; }
}