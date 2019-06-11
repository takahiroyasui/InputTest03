using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] int zAdjust = 50;

    Rigidbody rb;

    void Start()
    {
        this.rb = this.transform.GetComponent<Rigidbody> ();
    }

    void Update()
    {
        // mainCamera.transform.position = new Vector3(transform.position.x - 5.5f, transform.position.y + 2f, transform.position.z + 0f);
 
        if (Input.GetKeyDown ("joystick button 16")) {
            Debug.Log ("button A Down");
        }

        if (Input.GetKeyUp ("joystick button 16")) {
            Debug.Log ("button A Up");
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey ("joystick button 16")) {
            Debug.Log ("button A On");
            rb.AddForce(new Vector3 (50.0f, 0.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey ("joystick button 18")) {
            Debug.Log ("button X On");
            rb.AddForce(new Vector3 (-50.0f, 0.0f, 0.0f));
        }


        float hori = Input.GetAxis ("Horizontal");
        float vert = Input.GetAxis ("Vertical");

        if (Input.GetKey(KeyCode.A) || hori < 0) {
            Debug.Log ("stick:" + hori);
            rb.AddForce(new Vector3(0.0f, 0.0f, 50.0f));
        }

        if (Input.GetKey(KeyCode.D) || hori > 0) {
            Debug.Log ("stick:" + vert);
            rb.AddForce(new Vector3(0.0f, 0.0f, -50.0f));
        }
    }
}
