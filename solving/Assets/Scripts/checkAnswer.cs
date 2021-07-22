using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkAnswer : MonoBehaviour
{
    public GameObject endGame,attention;
    public static int score;
    public Text scoreText;
    private void Start()
    {
        if(!PlayerPrefs.HasKey("BestScores"))
        {
            PlayerPrefs.SetString("BestScores", "0 0 0 0 0");
        }

        if(!PlayerPrefs.HasKey("score"))
        {
            score = 0;
        }    
        else
            score= PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }
    public void check()
    {
        if(ClickController.res==-1)
        {
            attention.SetActive(true);
            Time.timeScale = 0;

            return;
        }
        if (ClickController.res == GenerateExperssion.solution)
        {
            score += 10;
            scoreText.text = score.ToString();
            PlayerPrefs.SetInt("score", score);
            StartCoroutine(next());
        }
        if (ClickController.res != GenerateExperssion.solution)
        {
            endGame.SetActive(true);
            if (!PlayerPrefs.HasKey("BestScores"))
            {
                PlayerPrefs.SetString("BestScores", "0 0 0 0 0");
            }

            string[] bestScores = PlayerPrefs.GetString("BestScores").Split(' ');

            List<int> scores = new List<int>();
            for (int i = 0; i < 5; ++i)
                scores.Add(int.Parse(bestScores[i]));
            if (scores[0] < score)
            {
                scores[0] = score;
                scores.Sort();
            }
            scores.Sort();
            string s = "";
            for (int i = 0; i < 5; ++i)
               s+=scores[i].ToString()+" ";
            PlayerPrefs.SetString("BestScores", s);
            PlayerPrefs.DeleteKey("score");

            Time.timeScale = 0;
        }
    }

    IEnumerator next()
    {
        AnimationController.exit = true;
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(1);
    }
}
