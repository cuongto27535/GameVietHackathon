using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChuNhapNhay : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(Blink());
    }

    private IEnumerator Blink()
    {
        while (true)
        {
            text.enabled = true;
            yield return new WaitForSeconds(0.5f);
            text.enabled = false;
            yield return new WaitForSeconds(0.5f);
        }
    }
}