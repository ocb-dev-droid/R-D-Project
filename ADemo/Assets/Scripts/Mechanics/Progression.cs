using TMPro;
using Unity.VisualScripting;

using UnityEngine;


public class Progression : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currentLevelText;
    [SerializeField] TextMeshProUGUI xpText;
    [SerializeField] UnityEngine.UI.Image xpBar;

    
    
    public int targetXP = 100;
    [SerializeField] int targetXPIncrease = 100;

    int currentLevel;
    int currentXP;

    public void IncreaseXP(int amount)
    {
        currentXP += amount;
        CheckForLevelUp();
        updateUI();
    }
    
    private void CheckForLevelUp()
    {
        while(currentXP >= targetXP)
        {
            currentLevel++;
            currentXP -= targetXP;
            targetXP += targetXPIncrease;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLevel = 1;
        updateUI();
    }

    private void updateUI()
    {
        currentLevelText.text = "Level " + currentLevel;
        xpText.text = currentXP + "/" + targetXP;
        xpBar.fillAmount = (float)currentXP / (float)targetXP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  


}
