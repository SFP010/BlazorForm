using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorForm.Data;
using Microsoft.EntityFrameworkCore;

public class PatientServices
{
    private PatientDbContext dbContext;

    public PatientServices(PatientDbContext dbContext)
    {
        this.dbContext = dbContext;
    }


    public async Task<List<Patient>> GetPatientAsync()
    {
        return await dbContext.Patient.ToListAsync();
    }
}