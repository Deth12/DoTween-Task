using DG.Tweening;
using UnityEngine;

public class SwordLoadingTween : MonoBehaviour
{
    private void Start()
    {
        PlayAnimation();
    }

    // 65 -120 -20 -45
    public void PlayAnimation()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOLocalRotate(new Vector3(0, 0, 65f), 0.3f));
        sequence.Append(transform.DOLocalRotate(new Vector3(0, 0, -180f), 0.3f, RotateMode.LocalAxisAdd));
        sequence.Append(transform.DOLocalRotate(new Vector3(0, 0, -20f), 0.3f));
        sequence.Append(transform.DOLocalRotate(new Vector3(0, 0, -45f), 0.3f));
        sequence.SetLoops(-1);
    }
}
