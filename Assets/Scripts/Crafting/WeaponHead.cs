﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHead : MonoBehaviour {

	public enum HeadType {None, WoodAxe, MetalAxe, MithralAxe, WoodHammer, MetalHammer, MithralHammer, WoodBlade, MetalBlade, MithralBlade }

	public HeadType headType;

	public SpriteRenderer NewAppearance;

	public Sprite[] Appearance;

}
