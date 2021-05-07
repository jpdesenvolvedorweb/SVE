namespace Business
{
   public class Address : IInitial
    {
        public int Id { get; set; }

        public string PublicPlace { get; set; }

        public int? Number { get; set; }

        public string? Complement{ get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public char UF { get; set; }

        public string CEP { get; set; }

        public int IdPerson { get; set; }
    }
}
