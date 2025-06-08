using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector3 noTerrainPositon;
    public LayerMask terrainMask;
    Player Pm;

    // Start is called before the first frame update
    void Start()
    {
        Pm = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        Chunkchecker();
    }
    void Chunkchecker()
    {
        if (Pm.moveDir.x > 0 && Pm.moveDir.y == 0)
        {
            if(!Physics2D.OverlapCircle(player.transform.position + new Vector3(20,0 ,0), checkerRadius, terrainMask))
            {
                noTerrainPositon = player.transform.position + new Vector3(20, 0, 0);
                SpawnChunk();
            }
        }

        else if (Pm.moveDir.x == 0 && Pm.moveDir.y > 0)
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 0, 0), checkerRadius, terrainMask))
            {
                noTerrainPositon = player.transform.position + new Vector3(20, 0, 0);
                SpawnChunk();
            }
        }

        else if (Pm.moveDir.x == 0 && Pm.moveDir.y < 0)
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, 20, 0), checkerRadius, terrainMask))
            {
                noTerrainPositon = player.transform.position + new Vector3(20, 20, 0);
                SpawnChunk();
            }
        }

        else if (Pm.moveDir.x == 0 && Pm.moveDir.y < 0)
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, -20, 0), checkerRadius, terrainMask))
            {
                noTerrainPositon = player.transform.position + new Vector3(20, -20, 0);
                SpawnChunk();
            }
        }

        void SpawnChunk()
        {
            int rand = UnityEngine.Random.Range(0, terrainChunks.Count);
            Instantiate(terrainChunks[rand], noTerrainPositon, quaternion.identity);
        }
    }
}
