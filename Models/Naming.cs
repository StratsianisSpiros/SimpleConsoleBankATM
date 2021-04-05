

namespace BankSystem.Models
{
    abstract class Naming
    {
        public string BankName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get => Name + " " + Surname; }
    }
}
