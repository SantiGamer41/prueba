using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour {
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
 
    public void Init(bool isOffset) {
        Debug.Log($"Initializing tile with offset: {isOffset}");
        Debug.Log($"Base color: {_baseColor}, Offset color: {_offsetColor}");
        _renderer.color = isOffset ? _offsetColor : _baseColor;
        Debug.Log($"Renderer color set to: {_renderer.color}");
    }
 
    void OnMouseEnter() {
        _highlight.SetActive(true);
    }
 
    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
