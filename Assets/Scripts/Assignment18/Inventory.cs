using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    List<string> itemNames = new List<string>();
    public void AddItem(string item)
    {
        itemNames.Add(item);
    }
    public string ShowItems()
    {
        string ALL_ITEMS_IN_iNVENTORY = null;
        foreach (string name in itemNames)
        {
            ALL_ITEMS_IN_iNVENTORY += name;
            ALL_ITEMS_IN_iNVENTORY += ", ";
        }
        ALL_ITEMS_IN_iNVENTORY.TrimEnd();
        return ALL_ITEMS_IN_iNVENTORY;
    }
    public static Inventory operator +(Inventory obj1, Inventory obj2)
    {
        Inventory obj = new();
        foreach (string item in obj1.itemNames)
        {
            obj.AddItem(item);
        }
        foreach (string item in obj2.itemNames)
        {
            obj.AddItem(item);
        }
        return obj;
    }



}
