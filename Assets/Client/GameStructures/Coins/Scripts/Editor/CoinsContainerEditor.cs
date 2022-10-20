using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
//[CustomEditor(typeof(CoinsContainer))]
public class CoinsContainerEditor : Editor
{
    /*int keyNumber = 1;
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        CoinsContainer container = (CoinsContainer)target;
        if (container.Coins.Count > 0)
        {
            EditorGUILayout.BeginHorizontal("box");
            EditorGUILayout.LabelField("Weight");
            EditorGUILayout.LabelField("Coin");
            EditorGUILayout.EndHorizontal();
        }

        for (int i = 0; i < container.Coins.Count; i++)
        {
            EditorGUILayout.BeginHorizontal("Button");
            container.Weight[i] = EditorGUILayout.IntField(container.Weight[i]);
            container.Coins[i] = (Coin)EditorGUILayout.ObjectField(container.Coins[i], typeof(Coin), true);
            EditorGUILayout.EndHorizontal();
        }
        
        EditorGUILayout.BeginHorizontal("Button");

        if (GUILayout.Button("Add Coin") && container.CoinsCount > container.Coins.Count)
        {
            container.Weight.Add(keyNumber);
            container.Coins.Add(null);
        }
        
        if (GUILayout.Button("Remove Coin") && container.Coins.Count != 0)
        {
            var intList = new List<int>(container.Weight);
            var tilesList = new List<Coin>(container.Coins);

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == keyNumber)
                {
                    container.Weight.Remove(container.Weight[i]);
                    container.Coins.Remove(container.Coins[i]);
                }
            }
        }
        EditorGUILayout.EndHorizontal();
    
        if (keyNumber < 1)
            keyNumber = 1;

        EditorUtility.SetDirty(container);
    }*/
}
