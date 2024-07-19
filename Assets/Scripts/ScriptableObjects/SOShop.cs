using UnityEngine;
[CreateAssetMenu(fileName = "Create Shop Piece", menuName = "Create Shop Piece")]
public class SOShop : ScriptableObject
{
    public Sprite icon;
    public string iconName;
    public string description;
    public int cost;
}
