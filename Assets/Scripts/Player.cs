using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] GameObject Door;
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
   void OnTriggerStay()
   { 

           Destroy(Door);
        
   }
}
