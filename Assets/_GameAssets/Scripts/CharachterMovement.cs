using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterMovement : MonoBehaviour
{
    [SerializeField ] private float forward_Speed;
    [SerializeField ] private float horizontal_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_Delta = Input.GetAxis("Horizontal")*horizontal_Speed*Time.deltaTime;
        transform.Translate(horizontal_Delta,0,forward_Speed*Time.deltaTime);
    }
}
