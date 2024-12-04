using UnityEngine;
using lecture18;
public class GenericsTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameContainer<string> healingPotion = new GameContainer<string>();
        healingPotion.SetItem("Healing Potion");
        string item = healingPotion.GetItem();
        Debug.Log($"Stored item: {item}");
        string describtion = GameUtils.DescribeItem(item);
        Debug.Log(describtion);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
