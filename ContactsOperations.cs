public abstract class ContactsOperations
{
    public int ContactId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Phone_number { get; set; }

    protected ContactsOperations(){}

    protected ContactsOperations(int contactId)
    {
        ContactId = contactId;
    }
    
    protected ContactsOperations(int contactId, string name, string city, string state, string phone_number)
    {
        ContactId = contactId;
        Name = name;
        City = city;
        State = state;
        Phone_number = phone_number;
    }

    protected ContactsOperations(string name, string city, string state, string phone_number)
    {        
        Name = name;
        City = city;
        State = state;
        Phone_number = phone_number;
    }

    public abstract void Insert();
    public abstract void Delete();
    public abstract void Update();
    public abstract string Select();
    public abstract string SelectById();

}