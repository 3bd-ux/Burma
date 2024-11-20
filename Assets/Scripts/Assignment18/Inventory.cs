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
        return string.Join(", ", itemNames) + ".";
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
