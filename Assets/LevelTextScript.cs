using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTextScript : MonoBehaviour
{
    private Text levelText;
    private float fadeDuration = 1f;
    void Start()
    {
        levelText = GetComponent<Text>();
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator ShowText()
    {
        levelText.CrossFadeAlpha(1f, fadeDuration, false); // Fade in

        yield return new WaitForSeconds(fadeDuration); // Wait for fade in duration

        levelText.CrossFadeAlpha(0f, fadeDuration, false); // Fade out

        yield return new WaitForSeconds(fadeDuration);
    }
}
