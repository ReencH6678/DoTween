using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _distance;
    [SerializeField] private int _loops;

    void Start()
    {
        transform.DOMoveZ(_distance, _duration).SetLoops(_loops, LoopType.Yoyo);    
    }
}
