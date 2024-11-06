using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player1 =new Player();
        Player player2 =new Player();
        player1.InitializePlayer("Ahmad",100);
        player2.InitializePlayer("Sa3ed", 50);

        player1.Heal(true);
        player2.Heal(30);

        Player.ShowPlayerCount();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
