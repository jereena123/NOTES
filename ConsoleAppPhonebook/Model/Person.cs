namespace ConsoleAppPhonebook.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string city, string phoneNumber)
        {
            Name = name;
            City = city;
            PhoneNumber = phoneNumber;
        }
    }
}
