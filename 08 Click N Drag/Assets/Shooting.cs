using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject shotPrefab;
    float distancetodetect;

    // Start is called before the first frame update
    void Start()
    {
        distancetodetect = 8;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * distancetodetect, Color.green);

        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, distancetodetect);
        if(hit.collider != null && hit.collider.gameObject.tag == "square")
        {
            Instantiate(shotPrefab, transform.position, transform.rotation);
        }
    }
}
