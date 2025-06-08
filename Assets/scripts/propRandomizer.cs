using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propRandomizer : MonoBehaviour
{
    public List<GameObject> propSpwnPoint;
    public List<GameObject> proprefabs;
    // Start is called before the first frame update
    void Start()
    {
        spawnprops();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnprops()
    {
        foreach (GameObject sp in propSpwnPoint)
        {
            int rand = Random.Range(0, proprefabs.Count);
            Instantiate(proprefabs[rand], sp.transform.position, Quaternion.identity);
        }
    }
}
