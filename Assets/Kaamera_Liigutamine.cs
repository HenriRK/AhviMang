using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaamera_Liigutamine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 10) * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.position += new Vector3(0, 10, 0) * Time.deltaTime * Input.GetAxis("Vertical");
    }
}
