using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests: IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Barcelona", "2 Weeks", "My partner", "What an awesome time it was!");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetLocation_Returns_Location_String()
    {
      string location = "Barcelona";
      Place newPlace = new Place(location,"2 Weeks", "My partner", "What an awesome time it was!" );
      string result = newPlace.Location;
      Assert.AreEqual(location, result);
    }
    [TestMethod]
    public void SetLocation_SetLocation_String()
    {
      string location ="Barcelona";
      Place newPlace = new Place(location, "2 Weeks", "My partner", "What an awesome time it was!");
      string updatedLocation = "Madrid";
      newPlace.Location = updatedLocation;
      string result = newPlace.Location;
      Assert.AreEqual(updatedLocation, result);
    }
    [TestMethod]
      public void GetAll_ReturnsEmptyList_PlaceList()
      {
        List<Place> newList = new List<Place> {};
        List<Place> result = Place.GetAll();
        foreach(Place thisPlace in result)
        {
          Console.WriteLine("Places: "+ thisPlace.Location);
        }
        CollectionAssert.AreEqual(newList, result);
      }
    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string location01 = "Paris";
      string location02 = "Tokyo";
      Place newPlace01 = new Place(location01, "2 Weeks", "My partner", "What an awesome time it was!");
      Place newPlace02 = new Place(location02, "2 Weeks", "My partner", "What an awesome time it was!");
      List<Place> newList = new List<Place>{
        newPlace01, newPlace02
      };
      List<Place> result = Place.GetAll();
      foreach(Place thisPlace in result)
      {
        Console.WriteLine("Places:"+ thisPlace.Location);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
      public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
      {
        string location = "Yokohama";
        Place newPlace = new Place(location, "2 Weeks", "My partner", "What an awesome time it was!");
        int result = newPlace.Id;
        Assert.AreEqual(1,result);
      }
    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string location01 = "Berlin";
      string location02 = "Yokohama";
      Place place01 = new Place(location01, "2 Weeks", "My partner", "What an awesome time it was!");
      Place place02 = new Place(location02, "2 Weeks", "My partner", "What an awesome time it was!");
      Place result = Place.Find(2);
      Assert.AreEqual(place02, result);
    }
  }
}