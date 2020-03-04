using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
     public enum TypeofItem {
    
        List_1,
        list_2,
        list_3,
        list_4
    };
    public Sprite Sprite; //текстура иконки
    public string Name; //название
    public string ItemDescription; //описание
    public TypeofItem ItemType;
    public GameObject GameItem;
    public int counter;
    public int index;
   
}
