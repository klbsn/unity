using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    private Transform lookAtPlayer;
    // Start is called before the first frame update
    void Start()
    {
        lookAtPlayer = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
      transform.position = lookAtPlayer.position;  
    }
}
