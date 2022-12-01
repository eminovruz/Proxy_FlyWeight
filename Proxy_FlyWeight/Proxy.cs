//////////////////////////////// Proxy
class Employee
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Role { get; set; }
}

interface ISharedFolder
{
    void PerformRWOperations();
}

class SharedFolder : ISharedFolder
{
    public void PerformRWOperations()
    {
        // Some Code...
    }
}
class SharedFolderProxy : ISharedFolder
{
    private ISharedFolder? folder;
    private Employee? employee;
    
    public void PerformRWOperations()
    {
        //Does employee has access to the shared file
        if (employee.Role == "fehle" || employee.Role == "patron")
        {
            folder = new SharedFolder();
            Console.WriteLine("Obyekt Safe olundu");
            folder.PerformRWOperations();
        }
        else
            Console.WriteLine("Obyekt Safe olundu");
    }
}
