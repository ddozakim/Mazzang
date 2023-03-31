
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour{

    Vector3 pos; //현재위치

    float delta = 1.0f; // 좌(우)로 이동가능한 (x)최대값

    float speed = 1.0f; // 이동속도

  

    void Start()
    {
        pos = transform.position;

    }


    void Update()
    {

        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);
 
        transform.position = v;

        transform.Rotate(new Vector3(0,1,0)*180* Time.deltaTime);
    }
}
