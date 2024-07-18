class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}

class PhoneBook
{
    private List<Contact> contacts;

    public PhoneBook()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(string firstName, string lastName, string phoneNumber)
    {
        contacts.Add(new Contact { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber });
        SortContacts();
    }

    public void DisplayContacts()
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} - {contact.PhoneNumber}");
        }
    }

    private void SortContacts()
    {
        contacts = contacts.OrderBy(c => c.FirstName)
        .ThenBy(c => c.LastName)
        .ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var phoneBook = new PhoneBook();

        phoneBook.AddContact("John", "Doe", "123-456-7890");
        phoneBook.AddContact("Jane", "Doe", "987-654-3210");
        phoneBook.AddContact("Bob", "Smith", "555-555-5555");
        phoneBook.AddContact("Alice", "Johnson", "111-222-3333");

        Console.WriteLine("Contacts in the phone book:");
        phoneBook.DisplayContacts();
    }
}
