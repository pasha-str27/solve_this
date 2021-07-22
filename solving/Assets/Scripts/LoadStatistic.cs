using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadStatistic : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("BestScores"))
            PlayerPrefs.SetString("BestScores", "0 0 0 0 0");

        string []res = PlayerPrefs.GetString("BestScores").Split(' ');
        string str = "";
        for (int i = 0; i < 5; ++i)
            str += (i + 1).ToString() + ". " + res[4-i].ToString() + "\n";

        GetComponent<Text>().text = str;
    }
}
