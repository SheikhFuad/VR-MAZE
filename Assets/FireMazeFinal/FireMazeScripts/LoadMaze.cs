using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMaze : MonoBehaviour
{
    public void LoadFire()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadIce()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadWest()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadHaunted()
    {
        SceneManager.LoadScene(3);
    }
}