using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image[] ItemImages;
    public Text[] ItemTexts;
    public InventoryItemData[] ItemDatas;

    void Start()
    {
        for (int i = 0; i < ItemDatas.Length; i++)
        {
            ItemImages[i].sprite = ItemDatas[i].ItemImage;
            ItemTexts[i].text = $"{ItemDatas[i].ItemName} ({ItemDatas[i].ItemPrice:N0}P)";
        }
    }
}
