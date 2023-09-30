using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esfera : Figuras
{
    //«INHERITANCE»
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        int randomMaterial = Random.Range(0, this.materials.Count);
        GetComponent<MeshRenderer>().material = materials[randomMaterial];
    }

    // Update is called once per frame
    void Update()
    {

    }

    //«POLYMORPHISM»
    public override void OnCollisionEnter(Collision collisionInfo)
    {
        this.fuerzaInicial = new Vector3(Random.Range(0.0f,2.0f), 0, Random.Range(0.0f, 4.0f));
        this.rb.AddForce(this.fuerzaInicial);
    }
}
