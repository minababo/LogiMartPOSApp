public class Permission
{
    public int PermissionID { get; set; }
    public string PermissionName { get; set; }
    public string Module { get; set; }

    public int RoleID { get; set; }
    public Role Role { get; set; }
}
