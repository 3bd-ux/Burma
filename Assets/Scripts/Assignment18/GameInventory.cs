using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory Potions = new();
        Potions.AddItem("Healing Potion");
        Potions.AddItem("Strength Potion");

        Inventory Elixir = new();
        Potions.AddItem("Elixir");
        Potions.AddItem("Dark Elixir");

        Inventory CombninedInventory = new();
        CombninedInventory = Elixir + Potions;
        Debug.Log(CombninedInventory.ShowItems());


    }
}