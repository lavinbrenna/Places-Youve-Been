using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string Location {get;set;}
    public string StayDuration{get;set;}
    public string Who{get;set;}
    public string JournalEntry{get;set;}
    public int Id {get;}
    private static List<Place> _instances = new List<Place>{};

    public Place(string location, string stayDuration, string who, string journalEntry)
    {
      Location = location;
      StayDuration = stayDuration;
      Who = who;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id=_instances.Count;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}