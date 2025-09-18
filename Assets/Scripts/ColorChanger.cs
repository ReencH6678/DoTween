using DG.Tweening;  
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Color _color;
    [SerializeField] private int _loops;

    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _duration).SetLoops(_loops, LoopType.Yoyo);  
    }
}
