namespace Back_end.Models
{
    public class User
    {
        public User(int Id, string UserCode, string Name, string CPF, string Telephone, string PostalCode, string District,
            string City, string State, string Country, string Street, string? Number, string? Complement)
        {
            this.Id = Id;
            this.UserCode = UserCode;
            this.Name = Name;
            this.CPF = CPF;
            this.Telephone = Telephone;
            this.PostalCode = PostalCode;
            this.District = District;
            this.City = City;
            this.State = State;
            this.Country = Country;
            this.Street = Street;
            this.Number = Number;
            this.Complement = Complement;
        }

        public int Id { get; private set; } = 0;
        public string? UserCode { get; private set; }
        public string Name { get; private set; } = "";
        public string? Telephone { get; private set; }
        public string CPF { get; private set; } = "";
        public string? PostalCode { get; private set; }
        public string? District { get; private set; }
        public string? City { get; private set; }
        public string? State { get; private set; }
        public string? Country { get; private set; }
        public string? Street { get; private set; }
        public string? Number { get; private set; }
        public string? Complement { get; private set; }
    }
}