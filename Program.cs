using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  class Program
  {
    public static string addView = "";
    public static string addViewLower = addView.ToLower();
    static void Main()
    {
      Console.WriteLine("Welcome to your To Do List!");
      WelcomePage();
    }

    static void WelcomePage()
    {
      Console.WriteLine(@"Would you like to add an item to your list or view your list? 
      [ADD]/[VIEW]");
      addView = Console.ReadLine();
      string addViewLower = addView.ToLower();
      if(addViewLower == "add")
      {
        AddItem();
        WelcomePage();
      }
      else
      {
        ShowList();
        WelcomePage();
      }
    }

    // public static void Menu()
    // {
      
    // }
    public static void AddItem()
    {
      Console.WriteLine("Add description below:");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine("You added ***" + newItem.Description + "*** to your To-Do List"); //why is this not newItem.description or Item.Description????)
      //********add initial question add/view here! *********
    }

    static void ShowList()
    {
      // newList = new List<Item>{}; 
     List<Item> newList = Item.GetAll();
     for(int i = 0; i<newList.Count; i++ )
     {
       Console.WriteLine(newList[i].Description);
     }

    }
  }
}