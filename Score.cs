using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    
    public Transform player;
    public Text scoreText;
    public Text highScore;
    
    //public GameObject spawnerrain;
    //public GameObject spawnerrain2;
    public Material[] skyboxes;

    void Start () {
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        
    }
	
	
	 void Update () {
        int vahe = Mathf.RoundToInt(transform.position.z);
       
       scoreText.text =vahe.ToString("0");
      
        
        if(vahe > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", vahe);
            highScore.text = vahe.ToString();
        }

       
    }
    
}
