using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorFloor : MonoBehaviour
{

    ReflectionProbe rp;

    // Start is called before the first frame update
    void Start()
    {
        rp = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        rp.transform.position = new Vector3(
            Camera.main.transform.position.x, 
            Camera.main.transform.position.y * -1, 
            Camera.main.transform.position.z);

        rp.RenderProbe();
    }
}
