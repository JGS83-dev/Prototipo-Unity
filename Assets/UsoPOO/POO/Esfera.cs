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
        //Le agregamos movimiento inicial
        this.fuerzaInicial = new Vector3(Random.Range(10.0f, 15.0f), 0, Random.Range(10.0f, 12.0f));
        this.rb.AddForce(this.fuerzaInicial, ForceMode.Impulse);
    }

    //«POLYMORPHISM»
    public override void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Cilindro" || collisionInfo.gameObject.tag == "Pared")
        {
            Destroy(gameObject);
        }
    }
}
