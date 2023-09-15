using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BgScroll : MonoBehaviour
{
    public Camera your_camera;
    public float parallax_value;
    Vector2 length;

    Vector3 startposition;
    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
        length = GetComponentInChildren<SpriteRenderer>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relative_pos = your_camera.transform.position * parallax_value;
        Vector3 dist = your_camera.transform.position - relative_pos;
        if (dist.x > startposition.x + length.x)
        {
            startposition.x += length.x * 2;
        }
        if (dist.x < startposition.x - length.x)
        {
            startposition.x -= length.x * 2;
        }
        relative_pos.z = startposition.z;
        transform.position = startposition + relative_pos;

    }
}
