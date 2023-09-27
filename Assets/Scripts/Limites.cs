using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    [SerializeField]
    private float limiteX = -30.0f;
    [SerializeField]
    private float limitY = 30.0f;
    [SerializeField]
    private float limitZ = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.Range(-30,-20), Random.Range(5, 15), 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < limiteX)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > limitY)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > limitZ)
        {
            Destroy(gameObject);
        }
        AutoDestruccion();
    }

    IEnumerator AutoDestruccion()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
