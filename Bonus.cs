using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour
{
    public enum BonusType { RefinanceBoost, Advisor, ExtendLoan }
    public BonusType type;
    public float value;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        switch (type)
        {
            case BonusType.RefinanceBoost:
                GameStats.Instance.currentMoney += value;
                break;
            case BonusType.Advisor:
                GameStats.Instance.riskMultiplier = Mathf.Max(1f, GameStats.Instance.riskMultiplier - 0.5f);
                break;
            case BonusType.ExtendLoan:
                StartCoroutine(TempSlowDown());
                break;
        }

        Destroy(gameObject);
    }

    IEnumerator TempSlowDown()
    {
        float originalLoss = GameManager.Instance.lossRate;
        GameManager.Instance.lossRate *= 0.5f;
        yield return new WaitForSeconds(5f);
        GameManager.Instance.lossRate = originalLoss;
    }
}