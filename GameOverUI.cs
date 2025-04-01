using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    void Start()
    {
        float finalMoney = GameStats.Instance.currentMoney;
        float potentialSavings = GameStats.Instance.savingsPotential;

        float lostSavings = Mathf.Max(0, potentialSavings - finalMoney);
        float savingsUtilizedPercent = (finalMoney / potentialSavings) * 100f;

        resultText.text = $"נותר לך: ₪{finalMoney:n0}\n" +
                          $"חיסכון פוטנציאלי: ₪{potentialSavings:n0}\n" +
                          $"ניצלת {savingsUtilizedPercent:F1}% מהחיסכון האפשרי";
    }
}