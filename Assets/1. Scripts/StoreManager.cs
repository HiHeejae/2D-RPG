using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public InventoryItemData[] items;
    public GameObject Purchase_UI;
    public Image ItemImage;
    public Text ItemNameText;
    public Text ItemCoinText;
    public Text ItemExplainText;

    private Dictionary<string, InventoryItemData> itemDictionary;
    private string SelectedItemID;

    public void Start()
    {
        itemDictionary = new Dictionary<string, InventoryItemData>();
        foreach (InventoryItemData item in items)
        {
            itemDictionary[item.ItemID] = item;
        }
    }

    public void SelectItem(string itemID)
    {
        if (itemDictionary.TryGetValue(itemID, out InventoryItemData selectedItem))
        {
            Purchase_UI.SetActive(true);
            ItemImage.sprite = selectedItem.ItemImage;
            ItemNameText.text = selectedItem.ItemName;
            ItemCoinText.text = $"({selectedItem.ItemPrice:N0} Point)";
            ItemExplainText.text = selectedItem.ItemDescription;

            SelectedItemID = itemID;
        }
        else
        {
            Debug.LogError("Item ID not found: " + itemID);
        }
    }

    public void Purchase()
    {
        InventoryItemData selectedItem = itemDictionary[SelectedItemID];
        if (GameManager.Instance.Coin >= selectedItem.ItemPrice)
        {
            if (BackPackManager.Instance.AddItem(selectedItem))
            {
                GameManager.Instance.Coin -= selectedItem.ItemPrice;
                Debug.Log("성공");
            }
            else
            {
                Debug.Log("BackPack에 빈 공간이 없습니다.");
            }
        }
        else
        {
            Debug.Log($"잔액이 부족합니다. 잔액 : {GameManager.Instance.Coin}");
        }
    }
}
