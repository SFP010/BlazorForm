For the Blazor form I've set up a SQLite database to store the patients. 

My own development is within the files;

* Data/Patient.cs            - Model for the patient objects. 
* Data/PatientDbContext.cs   - To set up connection with the database
* Data/PatientServices.cs    - Logic for the form

* Pages/PatientForm.razor      - The Form itself
* Pages/Index.razor            - The homepage displaying the patients

I use VSCode. Running on this IDE I use the command; dotnet watch run
