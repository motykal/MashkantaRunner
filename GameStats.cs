using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static GameStats Instance;

    public float currentMoney = 500000f;
    public float interestRate = 3.5f;
    public int loanTerm = 20;
    public float riskMultiplier = 1f;
    public float savingsPotential;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}