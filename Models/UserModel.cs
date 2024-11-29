namespace AspNetCoreIntro2024.Models
{
    public class UserModel(int id, string name, string surname, DateTime dob, string pob)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Surname { get; set; } = surname;
        public DateTime DateOfBirth { get; set; } = dob;
        public string PlaceOfBirth { get; set; } = pob;
    }
}
