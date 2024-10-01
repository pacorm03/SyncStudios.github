using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RythmDisplay : MonoBehaviour
{
    Image _display;

    [SerializeField] Color _displayColor;
    [SerializeField] Color _highlightColor;

    [SerializeField] float _displayTime;

    private void Start()
    {
        _display = GetComponent<Image>();
        _display.color = _displayColor;
        Clock.Instance.TickEvent += Highlight;
    }

    void Highlight()
    {
        _display.color = _highlightColor;
        Invoke("UnHighlight", _displayTime);
    }

    void UnHighlight()
    {
        _display.color = _displayColor;
    }

}
