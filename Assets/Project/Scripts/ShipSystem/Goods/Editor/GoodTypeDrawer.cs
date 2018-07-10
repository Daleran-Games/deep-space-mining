using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;


namespace DaleranGames.LastShupToTauCeti
{
    [CustomPropertyDrawer(typeof(GoodType), false)]
    public class GoodTypeDrawer : PropertyDrawer
    {
        static List<GoodType> goodTypes = Enumeration.GetAll<GoodType>().ToList();
        string[] goodNames = GetNames(goodTypes);



        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            string name = property.displayName;

            SerializedProperty statName = property.FindPropertyRelative("_name");
            SerializedProperty statValue = property.FindPropertyRelative("_value");

            int index = 0;
            for (int i = 0; i < goodNames.Length; i++)
            {
                if (goodNames[i] == statName.stringValue)
                    index = i;
            }

            // Begin/end property & change check make each field
            // behave correctly when multi-object editing.
            EditorGUI.BeginProperty(position, label, property);
            {
                EditorGUI.BeginChangeCheck();
                if (label == GUIContent.none)
                    index = EditorGUI.Popup(position, index, goodNames);
                else
                    index = EditorGUI.Popup(position, name, index, goodNames);

                if (EditorGUI.EndChangeCheck())
                {
                    GoodType selected = Enumeration.FromName<GoodType>(goodNames[index]);

                    statName.stringValue = selected.Name;
                    statValue.intValue = selected.Value;
                }
            }
            EditorGUI.EndProperty();
        }

        static string[] GetNames(List<GoodType> types)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < types.Count; i++)
            {
                names.Add(types[i].Name);
            }
            return names.ToArray();
        }
    }
}

