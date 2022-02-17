using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 4;
    private float helth = 10;


    void Start()
    {

    }

    void Update()
    {
        var s = Input.GetAxis("Horizontal");
        var k = Input.GetAxis("Vertical");
        var a = Input.GetAxis("Jump");
        var direction = new Vector3(s, a, k);

        transform.position = transform.position + speed * direction * Time.deltaTime;
    }
}
