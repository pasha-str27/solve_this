using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    public void MainMenu()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.HasKey("score"))
        {
            if (!PlayerPrefs.HasKey("BestScores"))
            {
                PlayerPrefs.SetString("BestScores", "0 0 0 0 0");
            }

            string[] bestScores = PlayerPrefs.GetString("BestScores").Split(' ');

            List<int> scores = new List<int>();
            for (int i = 0; i < 5; ++i)
                scores.Add(int.Parse(bestScores[i]));
            if (scores[0] < PlayerPrefs.GetInt("score"))
            {
                scores[0] = PlayerPrefs.GetInt("score");
                scores.Sort();
            }

            string s = "";
            for (int i = 0; i < 5; ++i)
                s += scores[i].ToString() + " ";
            PlayerPrefs.SetString("BestScores", s);
            PlayerPrefs.DeleteKey("score");
        }

        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        AnimationController.exit = true;
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(0);
    }
}