using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
