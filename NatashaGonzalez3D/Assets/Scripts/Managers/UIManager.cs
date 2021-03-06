﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Image fadePanel;
    public float fadeSpeed = 2f;

    public IEnumerator FadeProcess (Action fadeCall) {
        fadePanel.gameObject.SetActive(true);
        fadePanel.enabled = true;
        yield return FadeTo(1);
        //EXTERNAL DESIRED METHOD SHOULD RUN HERE
        fadeCall.Invoke();
        //---------------------------------------
        yield return FadeTo(0);
    }

    public IEnumerator FadeProcess (Action<int> fadeCall, int invokeParam) {
        fadePanel.gameObject.SetActive(true);
        fadePanel.enabled = true;
        yield return FadeTo(1);
        //EXTERNAL DESIRED METHOD SHOULD RUN HERE
        fadeCall.Invoke(invokeParam);
        //---------------------------------------
        yield return FadeTo(0);
    }

    IEnumerator FadeTo (int targetValue) {
        while (fadePanel.color.a != targetValue)
        {
            MoveImageAlpha(fadePanel, targetValue, fadeSpeed * Time.deltaTime);
            yield return null;
        }
    }

    void MoveImageAlpha (Image image, float targetAlpha, float speed) {
        Color color = image.color;
        color.a = Mathf.MoveTowards(color.a, targetAlpha, speed);
        image.color = color;
    }
}
