using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class ParralaxInfinate : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float panjangSprite;
    [SerializeField] float posAwal;
    [SerializeField] float posCam;
    [SerializeField] float speed;
    [SerializeField] float gerakParallax;
    // Start is called before the first frame update
    void Start()
    {
        posAwal = transform.position.x;
        panjangSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gerakParallax = cam.transform.position.x * speed;
        posCam = cam.transform.position.x;
        if (posCam > posAwal + panjangSprite)
        {
            posAwal += panjangSprite * 2;
        }
        if (posCam < posAwal - panjangSprite)
        {
            posAwal -= panjangSprite * 2;
        }
        transform.position = new Vector3(posAwal + gerakParallax,transform.position.y,transform.position.z);
    }
}
