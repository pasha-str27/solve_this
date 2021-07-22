using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmExit : MonoBehaviour
{
    public GameObject window;
    public void ShowMassege()
    {
        Time.timeScale = 0;
        window.SetActive(true);
    }
}
