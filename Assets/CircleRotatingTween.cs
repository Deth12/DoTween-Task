using DG.Tweening;
using UnityEngine;

public class CircleRotatingTween : MonoBehaviour
{
    [SerializeField] private Transform firstPart;
    [SerializeField] private Transform secondPart;

    private void Start()
    {
        PlayAnimation();
    }
    
    public void PlayAnimation()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(firstPart.transform.DOLocalRotate(new Vector3(0f, 360, 0f), 1f, RotateMode.LocalAxisAdd));
        sequence.Join(secondPart.transform.DOLocalRotate(new Vector3(360f, 0, 0f), 1f, RotateMode.LocalAxisAdd));
        sequence.SetLoops(-1);
    }
}
