using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShell : MonoBehaviour
{
    public GameObject explosion;
    Rigidbody rb;


    void OnCollisionEnter(Collision col) {
            Debug.Log("Explosão 1");

        if (col.gameObject.tag == "tank") {
            Debug.Log("Explosão");
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, .1f);
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.forward = rb.velocity;
    }
}
