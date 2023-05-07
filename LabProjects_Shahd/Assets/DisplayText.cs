using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public float displayTime = 10f;

    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(DisplayTextForTime());
    }

    IEnumerator DisplayTextForTime()
    {
        text.enabled = true;
        yield return new WaitForSeconds(displayTime);
        text.enabled = false;
    }
}








