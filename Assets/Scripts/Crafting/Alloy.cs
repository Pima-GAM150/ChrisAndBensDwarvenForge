using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alloy : MonoBehaviour {

    public enum AlloyType { Wood, Metal, Mithral }

    public AlloyType alloyType;

    public int level;
    public float value;

    public Sprite appearance;
}
