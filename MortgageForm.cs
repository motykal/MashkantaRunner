using UnityEngine;
using UnityEngine.UI;

public class MortgageForm : MonoBehaviour
{
    public Slider amountSlider;
    public Dropdown termDropdown;
    public Dropdown rateDropdown;

    public void SubmitForm()
    {
        GameStats.Instance.currentMoney = amountSlider.value;

        string selectedTerm = termDropdown.options[termDropdown.value].text;
        int term = int.Parse(selectedTerm);
        GameStats.Instance.loanTerm = term;

        string selectedRate = rateDropdown.options[rateDropdown.value].text.Replace("%", "");
        float rate = float.Parse(selectedRate) / 100f;
        GameStats.Instance.interestRate = rate;

        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
}