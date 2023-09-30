using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Figuras : MonoBehaviour
{
    protected Vector3 fuerzaInicial = Vector3.zero;
    protected Rigidbody rb = null;
    [SerializeField]
    protected List<Material> materials = new List<Material>();

    public virtual void OnCollisionEnter(Collision collision)
    {
        Contador.contador += 1;
    }

    protected void Awake()
    {
        this.rb = GetComponent<Rigidbody>();
        int randomMaterial = Random.Range(0, this.materials.Count);
        GetComponent<MeshRenderer>().material = materials[randomMaterial];
    }
}
