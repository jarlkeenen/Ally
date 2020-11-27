using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VectorGraphics;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    public TabHandler tabHandler;

    public Image background;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabHandler.OnTabSelected(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabHandler.OnTabExit(this);
    }

    void Start()
    {
        background = GetComponent<Image>();
        tabHandler.Subscribe(this);
    }
}
