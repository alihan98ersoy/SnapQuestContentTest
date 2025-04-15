using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameInfoTextManager : MonoBehaviour
{

    public TextMeshProUGUI Text;
    public GameObject winPanel;

    private int counter = 0;

    public void SetTextwithNewCounter() 
    {
        Text.text = $"You found {++counter} of 3 POI";
        if (counter == 3)
            WinTheGame();
    }

    public void WinTheGame() 
    {
        winPanel.SetActive(true);
    }
}
