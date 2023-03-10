using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     
    private static GameManager instance;

    public int score = 0;

    public Text scoreCounter;

    public static GameManager Instance {
        get {
            if(instance==null) {
                instance = new GameManager();
            }
 
            return instance;
        }
    }
    
 
    void Awake()
    {
        instance = this;
        scoreCounter.text = $"Score: {score}";
    }
 
    public void UpdateScore()
    {
        score++;
        scoreCounter.text = $"Score: {score}";
        if (score >= 10)
        {
            Debug.Log("You win");
            SceneManager.LoadScene(0);
        }
    }
}
