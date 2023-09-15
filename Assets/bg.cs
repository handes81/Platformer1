using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] Vector3 posAwal;
    [SerializeField] float speed;
    [SerializeField] float length;
    // Start is called before the first frame update
    void Start()
    {
        posAwal = transform.position;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_camera.transform.position.x > posAwal.x + length)
        {
            posAwal.x += length*2;
        }
        else if (_camera.transform.position.x < posAwal.x - length)
        {
            posAwal.x -= length * 2;
        }
        transform.position = new Vector3(posAwal.x + (_camera.transform.position.x * speed), transform.position.y, transform.position.z);
    }
}
