using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class camfolchar : MonoBehaviour
{
    [SerializeField] AudioSource bgs;
    [SerializeField]GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        bgs.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x, transform.position.y);
    }
}
