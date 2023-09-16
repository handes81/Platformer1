using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{
    public footstep footstepController;
    Animator anim;
    
    [SerializeField] float speed = 0.01f;
    Rigidbody2D rb;
    [SerializeField] Vector3 gerak;
    
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D)){

            gerak.x = 1*speed * Time.deltaTime;
            anim.SetBool("jalan", true);
            anim.SetBool("diam", false);
            PerformFootstep();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gerak.x = -1* speed * Time.deltaTime;
        }else { gerak.x = 0;
            anim.SetBool("jalan", false);
            anim.SetBool("diam", true);
        }
        
        transform.Translate(gerak);
    }
    private void PerformFootstep()
    {
        footstepController.PlayFootstepSound();
    }
}
