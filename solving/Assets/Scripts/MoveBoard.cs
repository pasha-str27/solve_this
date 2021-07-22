using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoard : MonoBehaviour
{
    float speed;
    public GameObject window;
    void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
            speed = 0.1f;
        else
            speed = 0.1f + (float)PlayerPrefs.GetInt("score") / 1000;
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.y >= -2.2f)
            gameObject.transform.Translate(Vector2.down * speed * Time.deltaTime);
        else
        {
            if(!window.activeSelf)
            {
                window.SetActive(true);
                Time.timeScale = 1;
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
        }
    }
}
