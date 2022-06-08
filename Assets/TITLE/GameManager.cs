using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void NewGame()
    {
    SceneManager.LoadScene("LEVEL MENU1");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
