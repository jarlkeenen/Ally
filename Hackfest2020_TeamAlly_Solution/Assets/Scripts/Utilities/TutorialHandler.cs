using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHandler : MonoBehaviour
{
    public RectTransform pageHolder;
    private Vector3 screenLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;

    public void Start()
    {
        screenLocation = pageHolder.anchoredPosition;
    }

    public void NextPage()
    {
        float newXPosition = pageHolder.anchoredPosition.x - 900;
        pageHolder.anchoredPosition = new Vector2(newXPosition, 0);
    }
}
