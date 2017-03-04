using UnityEngine;
using System.Collections;

public class TerrainManager : MonoBehaviour {
    public Terrain terrainObj;
    TerrainData td;
	// Use this for initialization
	void Start () {
        td = terrainObj.GetComponent<TerrainData>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
