using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    Rigidbody2D rb;
    [SerializeField] Vector3 gerak;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            gerak.x = 1*Time.deltaTime*speed;
        }else if (Input.GetKey(KeyCode.A))
        {
            gerak.x = -1*Time.deltaTime* speed;
        }else { gerak.x = 0;}
        
        transform.Translate(gerak);
    }
}
