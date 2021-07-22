using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static bool exit;
    void Start()
    {
        GetComponent<Animation>().Play("toInvisible");
    }

    void Update()
    {
        if(exit)
        {
            GetComponent<Animation>().Play("toVisible");
            exit = false;
        }
    }
}
