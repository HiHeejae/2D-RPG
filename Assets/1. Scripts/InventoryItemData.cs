using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "Inventory/Item")]
public class InventoryItemData : ScriptableObject
{
    public string ItemID;
    public string ItemName;
    public Sprite ItemImage;
    public int ItemPrice;
    public string ItemDescription;
}
