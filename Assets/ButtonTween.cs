using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTween : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float onHoverScaleMultipiler = 1.1f;

    public void OnPointerClick(PointerEventData eventData)
    {
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOPunchScale(transform.localScale * 0.6f, 0.3f));
        sequence.Join(transform.DOShakeRotation(
            0.2f, new Vector3(0f,0f,60f), 30, 30));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one * onHoverScaleMultipiler, 0.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one, 0.2f);
    }
}
