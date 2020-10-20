using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBeh : MonoBehaviour
{
    
    public GameObject Sphere;

    private Vector3 diff;

    void Start(){
    	diff = transform.position - Sphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Sphere.transform.position + diff;
    }
}
