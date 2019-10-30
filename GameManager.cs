using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    public GameObject GameOverUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void gameover()
    {
        GameOverUI.SetActive(true);
    }
    
        
    
}

