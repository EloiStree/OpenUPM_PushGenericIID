using UnityEngine;

public class TDD_Conversion_QuestGamepads : MonoBehaviour {

    public STRUCT_QuestGamepads2020 from;
    public STRUCT_QuestGamepadsRawInt2020 to;
    public STRUCT_QuestGamepads2020 recovered;


    public void OnValidate()
    {
        IntegerToOculusGamepads2020Utility.Parse(ref from, ref to);
        IntegerToOculusGamepads2020Utility.Parse(ref to, ref recovered);
    
    }
}
