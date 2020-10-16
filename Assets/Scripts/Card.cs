using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 startPos;
    private bool isInHand = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isInHand)
            return;

        transform.DORewind();
        transform.DOMove(new Vector3(startPos.x, startPos.y + 40f, startPos.z), 0.3f);
        transform.DOScale(Vector3.one * 1.4f, 0.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isInHand)
            return;
        
        transform.DORewind();
        transform.DOMove(startPos, 0.2f);
        transform.DOScale(Vector3.one, 0.2f);
    }

    public void OnHandPlaced()
    {
        startPos = transform.position;
        isInHand = true;
    }
}
