using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Spiel beendet.");
        Application.Quit();
    }

    public void Optionen()
    {
        Debug.Log("Optionen öffnen");
    }
}
