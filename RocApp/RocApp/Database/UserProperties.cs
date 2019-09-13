using SQLite;

namespace RocApp.Database
{
    public class UserProperties
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mood1 { get; set; }
        public string Mood2 { get; set; }
        public string Mood3 { get; set; }
        public string Mood4 { get; set; }
        public string Mood5 { get; set; }
        public string Mood6 { get; set; }
        public string Mood7 { get; set; }
        public string Mood8 { get; set; }

        public void CVProperties(string fullname, string username, string password, string mood1, string mood2, string mood3, string mood4, string mood5
            , string mood6, string mood7, string mood8)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mood1 = mood1;
            Mood2 = mood2;
            Mood3 = mood3;
            Mood4 = mood4;
            Mood5 = mood5;
            Mood6 = mood6;
            Mood7 = mood7;
            Mood8 = mood8;

        }

        public UserProperties()
        {

        }
    }
}