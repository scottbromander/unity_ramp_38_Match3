using UnityEngine;
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

	private Dictionary<PieceType, GameObject> piecePrefabDict;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
