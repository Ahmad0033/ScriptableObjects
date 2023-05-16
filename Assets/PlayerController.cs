using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerData playerData;

    private void Start()
    {
        Debug.Log("Player Name: " + playerData.playerName);
        Debug.Log("Player Level: " + playerData.playerLevel);
        Debug.Log("Player Score: " + playerData.playerScore);
    }
}
