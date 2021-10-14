using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExchangePanel : MonoBehaviour
{
    public RectTransform panel;

    public void Open()
    {
        panel.localPosition = new Vector2(0, 0);
    }
    public void Close()
    {
        panel.localPosition = new Vector2(800, 0);
    }
}