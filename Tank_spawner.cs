using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_spawner : MonoBehaviour
{
    public GameObject tankprefab;
    void Start()
    {
        Instantiate(tankprefab,transform.position,Quaternion.identity);
    }

    
}
