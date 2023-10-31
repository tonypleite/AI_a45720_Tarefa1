using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject explosion;
    float speed = 0f;
    float ySpeed = 0f;
    float mass = 40;
    float force = 5;
    float drag = 1;
    float gravity = -9.8f;
    float gAccel;
    float acceleration;


    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "tank") {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    private void Start() {

        acceleration = force / mass;
        speed += acceleration * 1;
        gAccel = gravity / mass;
    }

    void LateUpdate() {

        speed *= (1 - Time.deltaTime * drag);
        ySpeed += gAccel * Time.deltaTime;
        this.transform.Translate(0.0f, ySpeed, speed);
    }
}
