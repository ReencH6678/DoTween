using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private int _loops;
    private void Start()
    {
        transform.DORotate(_rotation, _duration).SetLoops(_loops, LoopType.Yoyo);
    }
}
