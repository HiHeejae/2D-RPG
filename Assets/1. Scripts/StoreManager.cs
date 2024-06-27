using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorManager : MonoBehaviour
{
    public InventoryItemData[] items;
    public GameObject Purchase_UI;
    public Image ItemImage;
    public Text ItemNameText;
    public Text ItemCoinText;
    public Text ItemExplainText;

    private Dictionary<string, InventoryItemData> itemDictionary;

    public void Start()
    {
        itemDictionary = new Dictionary<string, InventoryItemData>();
        foreach (InventoryItemData item in items)
        {
            itemDictionary[item.ItemID] = item;
        }

        Debug.Log("À±ÈñÀç´Â »ì¾ÆÀÖ´Ù");
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
        }
        else
        {
            Debug.LogError("Item ID not found: " + itemID);
        }
    }
}
