using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movimiento : MonoBehaviour
{
public float velocidad;
public float velRotacion;
public float velocidadMax;
private float vel2;
private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Space)){
        rigid.AddForce(transform.forward * velocidad);
        }
        else{
         rigid.velocity = Vector3.zero;
        }
        gameObject.transform.Rotate(0,Input.GetAxis("Horizontal")*velRotacion,0);
    }
}
