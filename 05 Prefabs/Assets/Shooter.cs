using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject shot_prefab;
    public GameObject shot_Loc;

    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * 50 * horizontal * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shot_prefab, shot_Loc.transform.position, shot_Loc.transform.rotation);
        }


    }
}
