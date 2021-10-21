using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLogs : MonoBehaviour {
    private int counter;

    // Start is called before the first frame update
    void Start() {
        counter = 0;
    }

    // Update is called once per frame
    void Update() {
        counter++;
        Debug.Log("Object: " + gameObject.name +
                  " - Tag: " + gameObject.tag +
                  " - Counter: " + counter);
    }
}
