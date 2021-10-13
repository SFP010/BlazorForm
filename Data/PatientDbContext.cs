using Microsoft.EntityFrameworkCore;


namespace BlazorForm.Data
{
    public class PatientDbContext : DbContext
{
    public PatientDbContext(DbContextOptions<PatientDbContext> options)
        : base(options)
    {

    }

    public DbSet<BlazorForm.Data.Patient> Patient { get; set; }
}
}
