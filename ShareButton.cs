using UnityEngine;
using TMPro;

public class ShareButton : MonoBehaviour
{
    public TextMeshProUGUI shareText;

    public void ShareResult()
    {
        float money = GameStats.Instance.currentMoney;
        float savings = GameStats.Instance.savingsPotential;

        string message = $"🚀 שיחקתי במשכנתא ראנר! נותר לי ₪{money:n0} מתוך חיסכון פוטנציאלי של ₪{savings:n0}!" +
                         " רוצה לדעת כמה אתה יכול לחסוך? 💸";
        string urlEncoded = UnityEngine.Networking.UnityWebRequest.EscapeURL(message);
        string shareUrl = $"https://wa.me/?text={urlEncoded}";

        Application.OpenURL(shareUrl);
        if (shareText != null)
            shareText.text = "שיתוף בוצע ✅";
    }
}