using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlusMove : MonoBehaviour
{
    private bool revercable = true;
    [SerializeField] float interval = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Physics.gravity);
        if (revercable == true && Input.GetKey(KeyCode.Space))
        {
            Physics.gravity = new Vector3(0,100,0);
            revercable = false;
            Invoke("GravityReset", interval);
        }
    }

    private void GravityReset()
    {
        Physics.gravity = new Vector3(0,-9.8f,0);
        revercable = true;
    }
}
