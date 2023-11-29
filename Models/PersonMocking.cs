using System.Collections.Generic;

namespace ListBoxMVVM.Models
{
    public static class PersonMocking
    {
        public static List<PersonModel> GetPersons()
        {
            List<PersonModel> liste = new List<PersonModel>();
            liste.Add(new PersonModel { Name = "Schulze", Alter = 56, Adresse = "Bremen" });
            liste.Add(new PersonModel { Name = "Schmidt", Alter = 21, Adresse = "Kiel" });
            liste.Add(new PersonModel { Name = "Meier", Alter = 30, Adresse = "Bonn" });
            liste.Add(new PersonModel { Name = "Schneider", Alter = 29, Adresse = "Ulm" });
            liste.Add(new PersonModel { Name = "Müller", Alter = 26, Adresse = "Köln" });
            liste.Add(new PersonModel { Name = "Fischer", Alter = 68, Adresse = "Bremen" });
            liste.Add(new PersonModel { Name = "Klein", Alter = 73, Adresse = "Hamburg" });
            liste.Add(new PersonModel { Name = "Miller", Alter = 64, Adresse = "Köln" });
            liste.Add(new PersonModel { Name = "Abel", Alter = 77, Adresse = "Aachen" });
            liste.Add(new PersonModel { Name = "Smith", Alter = 46, Adresse = "Berlin" });
            liste.Add(new PersonModel { Name = "de Jong", Alter = 31, Adresse = "Essen" });
            liste.Add(new PersonModel { Name = "Mayer", Alter = 31, Adresse = "Hannover" });

            return liste;
        }
    }
}
