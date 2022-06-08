using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{


    public string name = "STG1";

    public void restartGame()
    {
        SceneManager.LoadScene(3);
    }
}