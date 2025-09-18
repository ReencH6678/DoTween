using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    [SerializeField] private string _replacementText;
    [SerializeField] private string _addedText;
    [SerializeField] private string _hackedText;

    [SerializeField] private float _duration;
    [SerializeField] private int _loops;

    private void Start()
    {
        Sequence sequence;

        sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_replacementText, _duration));
        sequence.Append(_text.DOText(_addedText, _duration).SetRelative());
        sequence.Append(_text.DOText(_hackedText, _duration, true, ScrambleMode.All));

        sequence.SetLoops(_loops, LoopType.Yoyo);
    }
}
