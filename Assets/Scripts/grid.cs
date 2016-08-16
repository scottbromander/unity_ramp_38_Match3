﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

	public enum PieceType {
		NORMAL, 
		COUNT
	}

	public int xDim;
	public int yDim;

	[System.Serializable]
	public struct PiecePrefab {
		public PieceType type;
		public GameObject prefab;
	}

	public PiecePrefab[] piecePrefabs;
	public GameObject backgroundPrefab;

	private Dictionary<PieceType, GameObject> piecePrefabDict;

	// Use this for initialization
	void Start () {
		piecePrefabDict = new Dictionary<PieceType, GameObject> ();

		for (int i = 0; i < piecePrefabs.Length; i++) {
			if(!piecePrefabDict.ContainsKey(piecePrefabs[i].type)){
				piecePrefabDict.Add(piecePrefabs[i].type, piecePrefabs[i].prefab);
			}
		}

		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				GameObject background = (GameObject)Instantiate (backgroundPrefab, new Vector3(x, y, 0), Quaternion.identity);
				background.transform.parent = transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
