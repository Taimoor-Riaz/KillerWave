using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopUpgradeManager : MonoBehaviour
{
    public static ShopUpgradeManager instance;
    [SerializeField] TextMeshProUGUI upgradeName;
    [SerializeField] TextMeshProUGUI upgradeDescription;
    [SerializeField] SOActor playerBullet;
    [SerializeField] SOActor player;
    [SerializeField] GameObject buyButton;
    [SerializeField] TextMeshProUGUI coinsText;
    int totalCoins;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(instance);
        if (!PlayerPrefs.HasKey("Coins"))
        {
            PlayerPrefs.SetInt("Coins", 0);
        }
        totalCoins = PlayerPrefs.GetInt("Coins");
        coinsText.text = "Coins : " + totalCoins.ToString();
    }

    public void AssignData(SOShop shop)
    {
        upgradeName.text = shop.name;
        upgradeDescription.text = shop.description;
        buyButton.SetActive(true);
        buyButton.GetComponent<Button>().onClick.RemoveAllListeners();
        buyButton.GetComponent<Button>().onClick.AddListener(() => UpgradeData(shop.name, shop.cost));
    }

    public void UpgradeData(string upgradeName, int cost)
    {
        switch (upgradeName)
        {
            case "Bullet":
                if (totalCoins >= cost)
                {
                    ReduceCoins(cost);
                    playerBullet.hitDamge += 1;
                }
                else
                {
                    Debug.Log("No Coins");
                }
                break;
            case "Health":
                if (totalCoins >= cost)
                {
                    ReduceCoins(cost);
                    player.health += 1;
                }
                else
                {
                    Debug.Log("No Coins");
                }
                break;
            case "Grenade":
                break;
        }
    }

    public void ReduceCoins(int cost)
    {
        totalCoins -= cost;
        PlayerPrefs.SetInt("Coins", totalCoins);
        coinsText.text = "Coins : " + totalCoins.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

   
}
