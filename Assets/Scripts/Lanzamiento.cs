using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzamiento : MonoBehaviour
{
    [SerializeField]
    private GameObject[] doroMunicion = null;
    [SerializeField]
    private GameObject puntoSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int indice = Random.Range(0,doroMunicion.Length);
            Instantiate(doroMunicion[indice],puntoSpawn.transform);
        }
    }
}
