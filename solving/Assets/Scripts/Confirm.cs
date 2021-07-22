using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirm : MonoBehaviour
{
    public void confirm()
    {
        Time.timeScale = 1;
        gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
    }
}
