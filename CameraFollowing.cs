using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform Target;
    private Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        offSet = transform.position - Target.position;
    }
    void CameraFollow()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, offSet.z + Target.position.z);
        transform.position = newPos;
    }
    void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraFollow();
    }
}
