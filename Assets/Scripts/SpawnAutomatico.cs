using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAutomatico : MonoBehaviour
{
    [SerializeField]
    private GameObject[] doroEsferas = null;
    [SerializeField]
    private GameObject[] doroCilindros = null;
    [SerializeField]
    protected List<Transform> spawnsDoroEsferas = new List<Transform>();
    [SerializeField]
    protected List<Transform> spawnsDoroCilindros = new List<Transform>();
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerarDoro()
    {
        int indice = Random.Range(0, doroEsferas.Length);
        int indiceEsferas = Random.Range(0, spawnsDoroEsferas.Count);
        Instantiate(doroEsferas[indice], spawnsDoroEsferas[indiceEsferas]);

        int indiceCilindros = Random.Range(0, doroCilindros.Length);
        int indiceCilindrosSpawn = Random.Range(0, spawnsDoroCilindros.Count);
        Instantiate(doroCilindros[indiceCilindros], spawnsDoroCilindros[indiceCilindrosSpawn]);
    }
}
