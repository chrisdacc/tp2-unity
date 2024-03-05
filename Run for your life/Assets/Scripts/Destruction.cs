using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject spawnPlatform;
    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        GameObject platform = Instantiate(spawnPlatform);
        platform.transform.position = GameObject.Find("PlatformGenerator").transform.position;
    }
}
