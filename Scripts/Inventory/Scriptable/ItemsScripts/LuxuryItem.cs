using UnityEngine;

namespace InventorySystem
{

[CreateAssetMenu(fileName = "LuxuryItem", menuName = "Inventory/LuxuryItem")]
public class LuxuryItem : InventoryItem, IMarketable
{
    [field:SerializeField] public float RegPrice { get; set; }
}

}
