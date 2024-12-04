using Unity.VisualScripting;
using UnityEngine;
namespace lecture18{
public class GameContainer<T>
{
    T item;
    public void SetItem(T item)
    {
        this.item = item;
    }
    public T GetItem()
    {
        return item;
    }
}
}