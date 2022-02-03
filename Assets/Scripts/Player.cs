using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1f;
    void Start()
    {

    }

    void Update()
    {


       var a = Input.GetAxis("Horizontal");
       var b = Input.GetAxis("Vertical");

       var direction = new Vector3(a, 0, b);

       transform.position = transform.position + Speed * direction * Time.deltaTime;

    }
}
