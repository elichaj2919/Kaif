using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coinCountText;
    [SerializeField]
    private Slider healthSlider;

    [SerializeField]
    private GameObject gameOverUI;

    public void UpdateCoinText(int coins)
    {
        coinCountText.text = "Coins: " + coins;
    }
    public void UpdateHealth(float health) 
    {
        healthSlider.value = health; 
    
    
    
    }
    public void ShowGameOverUI()
    {
        gameOverUI.SetActive(true);
    }
}
