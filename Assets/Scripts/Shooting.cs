using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bulletprefap;
    public Transform postionspwan;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(Bulletprefap, postionspwan.transform.position, postionspwan.transform.rotation);

        }
    }
}
