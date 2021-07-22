using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickController : MonoBehaviour, IPointerClickHandler
{
    public Image[] stickers;
    public static int res;

    private void Start()
    {
        res = -1;
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        for (int i = 0; i < stickers.Length; ++i)
            stickers[i].gameObject.GetComponent<Image>().enabled = false;
        gameObject.transform.GetChild(1).gameObject.GetComponent<Image>().enabled = true;

        res = int.Parse(gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text);
    }
}
