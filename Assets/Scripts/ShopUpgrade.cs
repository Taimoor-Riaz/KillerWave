using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
public class ShopUpgrade : MonoBehaviour
{
    [SerializeField] SOShop shop;
    Button button;

    private void Awake()
    {
        transform.GetChild(0).gameObject.GetComponent<Image>().sprite = shop.icon;
        transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = shop.cost.ToString();
        button = GetComponent<Button>();
        button.onClick.AddListener(SendData);
    }

    public void SendData()
    {
        ShopUpgradeManager.instance.AssignData(shop);
    }
}
