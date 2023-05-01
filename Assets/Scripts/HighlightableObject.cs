using UnityEngine;

public class HighlightableObject : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _highlightedColor;
    private Material _material;

    private void Awake()
    {
        _material = _meshRenderer.material;
    }

    public void Highlight()
    {
        _material.color = _highlightedColor;
    }

    public void Reset()
    {
        _material.color = Color.white;
    }
}
