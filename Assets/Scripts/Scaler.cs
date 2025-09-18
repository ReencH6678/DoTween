using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _ratio;
    [SerializeField] private int _loops;

    private void Start()
    {
        transform.DOScale(_ratio, _duration).SetLoops(_loops, LoopType.Yoyo);
    }
}
