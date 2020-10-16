using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardsDistributor : MonoBehaviour
{
    [SerializeField] private Button distributeButton = default;
    [SerializeField] private Transform hand = default;
    
    [SerializeField] private Card[] cards = default;
    [SerializeField] private float cardsPadding = 20f;
    [SerializeField] private float distributionTime = 0.6f;

    private void Start()
    {
        distributeButton?.onClick.AddListener(DistributeCards);
    }

    private void DistributeCards()
    {
        distributeButton.transform.DOScale(Vector3.zero, 0.4f);
        var sequence = DOTween.Sequence();
        for (int i = 0; i < cards.Length; i++)
        {
            var pos = hand.position;
            var nextCardPos = new Vector3((pos.x + cardsPadding * i), pos.y, pos.z);
            sequence.Append(cards[i].transform.DOMove(nextCardPos, distributionTime));
            sequence.Join(cards[i].transform.DOPunchRotation(new Vector3(0f, 0f, 20f), distributionTime / 2, 10));
        }
        sequence.OnComplete(OnDistributionComplete);
    }

    private void OnDistributionComplete()
    {
        foreach (var card in cards)
            card.OnHandPlaced();
    }
}
