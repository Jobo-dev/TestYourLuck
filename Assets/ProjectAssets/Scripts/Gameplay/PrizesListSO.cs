using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PrizesValueList", menuName = "Prizes/ValueList")]
public class PrizesListSO : ScriptableObject
{
    public List<float> prizesList;
}
