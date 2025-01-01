public class User
{
    public int UserID { get; set; }
    public string FullName { get; set; }
    public string MobileNumber { get; set; }
    public string UserType { get; set; }

    public int RoleID { get; set; }
    public Role Role { get; set; }

    public int LoginID { get; set; }
    public Login Login { get; set; }
}
