using Databaseku.Model;
using Microsoft.EntityFrameworkCore;

namespace Databaseku;

public class Database : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Chat> Chat { get; set; }
    // public DbSet<Specialist> Specialists { get; set; }
    // public DbSet<DoctorPatient> DoctorPatients{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=./database.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(doc =>
        {
            doc.HasKey(d => d.DoctorID);
            doc.HasMany(d => d.Patients).WithMany(p => p.Doctor);
        });

        modelBuilder.Entity<Patient>(pat =>
        {
            pat.HasKey(p => p.PatientID);
        });
        modelBuilder.Entity<Chat>(ch =>
        {
            ch.HasKey(c => c.ChatID);
        });


        // modelBuilder.Entity<Specialist>(spec =>
        // {
        //     spec.HasKey(sp => sp.SpecialistID);
        //     spec.HasMany(sp=>sp.Doctors).WithOne(dc=>dc.Specialist);
        // });

        // modelBuilder.Entity<DoctorPatient>(dp =>{
        //     dp.HasKey(x=> new {x.DoctorID,x.PatientID});
        //     dp.Property(x=>x.MedicalRecord).HasColumnType("TEXT");
        // });
    }
}
