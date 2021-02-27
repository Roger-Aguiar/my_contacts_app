public abstract class ContactsOperations
{
    private int contactId;
    private string name;
    private string city;
    private string state;
    private string phone_number;

    public int ContactId { get => contactId; set => contactId = value; }
    public string Name { get => name; set => name = value; }
    public string City { get => city; set => city = value; }
    public string State { get => state; set => state = value; }
    public string Phone_number { get => phone_number; set => phone_number = value; }

    public abstract void Insert();
    public abstract void Delete();
    public abstract void Update();
    public abstract void Select();

}