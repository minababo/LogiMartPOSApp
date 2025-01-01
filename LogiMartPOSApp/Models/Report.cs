using System;

public class Report
{
    public int ReportID { get; set; }
    public DateTime GeneratedDate { get; set; }
    public string ReportType { get; set; }
    public string Details { get; set; }

    public int Rep_UserID { get; set; }
    public User User { get; set; } // Navigation Property
}
