using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void Level(int level)
    {
        Debug.Log("Lade Level " + level);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }
    public void Optionen()
    {
        Debug.Log("Optionen öffnen");
    }
}
