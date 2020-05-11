using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{   
    public Transform trans;
    public float startPoint = 0;
    bool flag = true;
    public float repeatTime = .1f;
    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
        InvokeRepeating("Move", 0, repeatTime);
    }

    // Update is called once per frame
    void Move()
    {
        if(trans.position.x > startPoint + .25f) {
            flag = false;
        }
        else if(trans.position.x > startPoint - .25f) {
            flag = true;
        }

        if(flag) {
            trans.position = new Vector3(trans.position.x + .1f, trans.position.y, 100);
        }
        else {
            trans.position = new Vector3(trans.position.x - .1f, trans.position.y, 100);
        }
    }
}
