using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof (Item))]
public class ItemInspector : Editor
{
    public override void OnInspectorGUI()
    {
        Item currentItem = (Item)target;

        string newItemName = EditorGUILayout.TextField("Item name", currentItem.Name);
        currentItem.Name = newItemName;

        string newItemDescription = EditorGUILayout.TextField("Item description", currentItem.ItemDescription);
        currentItem.ItemDescription = newItemDescription;

        currentItem.Sprite = (Sprite)EditorGUILayout.ObjectField(currentItem.Sprite, typeof(Sprite), GUILayout.Width(200), GUILayout.Height(200));

        currentItem.ItemType = (Item.TypeofItem)EditorGUILayout.EnumPopup("Item type", currentItem.ItemType);

        currentItem.GameItem = (GameObject)EditorGUILayout.ObjectField(currentItem.GameItem, typeof(GameObject), GUILayout.Width(200), GUILayout.Height(200));

    }
}
