using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject cubePrefab;
    public Vector3[] vectors;
    public string[] names;
    void Start()
    {
        for (int i = 0; i < vectors.Length; i++) {
            SpawnCube(i);
        }      
    }
    private void SpawnCube(int index) {
        GameObject cube = Instantiate(cubePrefab) as GameObject;
        cube.transform.position = vectors[index];
        //cube.name = "Test " + (index + 1).ToString();
        cube.name = names[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
