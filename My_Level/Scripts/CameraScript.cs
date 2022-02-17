using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] Transform Gamer;
    [SerializeField] Transform Camera;
    [Range(0, 1)]
    [SerializeField] float factor;


    private float speed = 2;
    private Quaternion origRot;
    private Quaternion cachedRot;
    void Start()
    {
        origRot = Gamer.rotation;
        cachedRot = Camera.rotation;
    }
    void Update()
    {

        Camera.rotation = Quaternion.Lerp(origRot, cachedRot, factor);
        //var dir = Gamer.position - Camera.position;
        //var ndir = Vector3.RotateTowards(Gamer.forward, dir, speed * Time.deltaTime, 0);
        //Camera.rotation = Quaternion.LookRotation(ndir);
    }
}
