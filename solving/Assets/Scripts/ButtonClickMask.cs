using UnityEngine;
using UnityEngine.UI;

public class ButtonClickMask : MonoBehaviour
{
    [Range(0f, 1f)] 
    public float AlphaLevel = 1f; 
    private Image bt;

    void Start()
    {
        bt = gameObject.GetComponent<Image>();
        bt.alphaHitTestMinimumThreshold = AlphaLevel; 
    }
}