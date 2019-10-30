using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public move move;
    public void LevelTwo()
    {
        SceneManager.LoadScene("lv2", LoadSceneMode.Additive);
        
    }
    public void LevelThree()
    {
        SceneManager.LoadScene("lv3", LoadSceneMode.Additive);

    }
    public void Restart()
    {
        //SceneManager.LoadScene("infinite", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        move.enabled = true;
        Time.timeScale = 1f;
    }
    public void Infinity()
    {
        SceneManager.LoadScene("infinite");
        //move.enabled = true;
        Time.timeScale = 1f;

    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
        move.enabled = true;
        Time.timeScale = 1f;

    }
    public void exit()
    {
        Application.Quit();
    }

}
