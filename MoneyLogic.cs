using UnityEngine;

public class MoneyLogic : MonoBehaviour
{
    public float baseLossPerSecond = 10f;

    private void Update()
    {
        float deltaLoss = baseLossPerSecond * GameStats.Instance.interestRate * 
                          GameStats.Instance.riskMultiplier * Time.deltaTime;

        GameStats.Instance.currentMoney -= deltaLoss;

        if (GameStats.Instance.currentMoney <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}