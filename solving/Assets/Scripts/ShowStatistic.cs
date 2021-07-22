using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowStatistic : MonoBehaviour
{
    public void Stat()
    {
        Time.timeScale = 1;
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        AnimationController.exit = true;
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(2);
    }
}
