namespace Databaseku.Model;

public class Specialist
{
    public int SpecialistID {get;set;}
    public string Name {get;set;}
    public IEnumerable<Doctor> Doctors{get;set;}

}
