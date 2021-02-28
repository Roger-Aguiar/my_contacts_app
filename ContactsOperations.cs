public abstract class ContactsOperations
{
    public int ContactId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Phone_number { get; set; }
    
    public abstract void Insert();
    public abstract void Delete();
    public abstract void Update();
    public abstract string Select();
    public abstract string SelectById();

}