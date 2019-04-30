using System;
using System.Collections.Generic;

namespace JobBoard.Models
{

  public class JobOpening
  {
    private string _title;
    private string _description;
    private int _pay;
    
    private static List<JobOpening> _allJobs = new List<JobOpening>();
    private Dictionary<string, string> _contact = new Dictionary<string, string>() {
      { "Name", "" },
      { "Email", "" },
      { "Phone", ""}
    };

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle (string title)
    { 
      _title = title;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription (string description)
    { 
      _description = description;
    }

    public int GetPay()
    {
      return _pay;
    }

    public void SetPay (int pay)
    { 
      _pay = pay;
    }

    public JobOpening(string title, string description, int pay, string name, string email, string phone)
    {
      _title = title;
      _description = description;
      _pay = pay;
      _contact["Name"] = name;
      _contact["Email"] = email;
      _contact["Phone"] = phone;

      _allJobs.Add(this);
    }

    public Dictionary<string, string> GetContactInfo()
    {
      return _contact;
    }
    
    public static List<JobOpening> GetAll()
    {
      return _allJobs;
    }

  }
}