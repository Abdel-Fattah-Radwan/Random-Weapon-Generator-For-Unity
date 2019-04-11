﻿using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class WeaponBody : MonoBehaviour
{
	[SerializeField] WeaponType type;

	[SerializeField] private Transform stockTransform;
	[SerializeField] private Transform handleTransform;
	[SerializeField] private Transform magazineTransform;
	[SerializeField] private Transform scopeTransform;
	[SerializeField] private Transform barrelTransform;

	[SerializeField] private List<Transform> firePoints;

	public WeaponType Type { get => type; set => type = value; }

	public Transform StockTransform { get => stockTransform; set => stockTransform = value; }
	public Transform HandleTransform { get => handleTransform; set => handleTransform = value; }
	public Transform MagazineTransform { get => magazineTransform; set => magazineTransform = value; }
	public Transform ScopeTransform { get => scopeTransform; set => scopeTransform = value; }
	public Transform BarrelTransform { get => barrelTransform; set => barrelTransform = value; }

	public List<Transform> FirePoints { get => firePoints; set => firePoints = value; }
}