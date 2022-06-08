using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void STG1()
    {
        SceneManager.LoadScene("STG1");
    }
    public void STG2()
    {
        SceneManager.LoadScene("STG2");
    }
    public void STG3()
    {
        SceneManager.LoadScene("STG3");
    }
    public void STG4()
    {
        SceneManager.LoadScene("STG4");
    }
    public void LevelBack()
    {
        SceneManager.LoadScene("TITLEE");
    }
}