using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            GameObject anime = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
