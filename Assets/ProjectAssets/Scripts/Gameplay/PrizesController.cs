using UnityEngine;

public class PrizesController : MonoBehaviour
{
    [SerializeField] PrizesListSO prizesListSO;

    [SerializeField] private GameObject prizesContainer;

    [SerializeField] private GameObject prizePrefab;

    private int prizesCount = 0;


    private void Start()
    {
        prizesCount = prizesListSO.prizesList.Count;
    }

    void GeneratePrizes()
    {
        for(int i = 0; i < prizesCount; i++)
        {
            GameObject prize = Instantiate(prizePrefab, prizesContainer.transform, false);
            PrizeElement prizeElement = prize.GetComponent<PrizeElement>();
            prizeElement.SetOptionValue(i);
            prizeElement.SetPrizeValue(i);
            prizeElement.SetTextValues();
        }
    }
}
