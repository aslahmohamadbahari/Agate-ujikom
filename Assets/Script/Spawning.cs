using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject Horse;

    int interval = 1;

    private void Start()
    {
        StartCoroutine(spawnAnimalHorse());
    }

    IEnumerator spawnAnimalHorse()
    {
        yield return new WaitForSeconds(interval);
        Instantiate(Horse);
    }
}
