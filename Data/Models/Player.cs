namespace VBS.Data.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public int PlayerNumber { get; set; }

        public bool IsCapitan { get; set; }

        public int TeamId { get; set; }


    }
}
