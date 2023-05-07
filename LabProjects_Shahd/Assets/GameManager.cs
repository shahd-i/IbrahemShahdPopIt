using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int balloonpopped = 0;
    [SerializeField] TextMeshProUGUI scoreTxt;
    int level;
    public int score;




    void Start()
    {
        PersistentData.Instance.GetScore();
        level = SceneManager.GetActiveScene().buildIndex - 1;
        DisplayScore();
 
    }
    public void PopBalloon(int score)
    {
        PersistentData.Instance.SetScore(score);
        balloonpopped = balloonpopped + score;
        DisplayScore();


    }
    public void AddPoints(int points)
    {
        balloonpopped += points;
    }

        void Update()
    {
        score = PersistentData.Instance.GetScore();
    }
    public void DisplayScore()
    {
        scoreTxt.text = "Score: " + balloonpopped;
    }

    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
