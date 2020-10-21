using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableIR : MonoBehaviour
{
	private CameraEffect ce;

    // Start is called before the first frame update
    void Start()
    {
        ce = Camera.main.GetComponent<CameraEffect>();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    public void ToggleIR(){
    	ce.m_Enable = !ce.m_Enable;
    }
}
