using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdjust : MonoBehaviour
{
    CinemachineCameraOffset offset;
    public Vector3 goalOffsetUp;
    public Vector3 goalOffsetDown;
    public GameObject cine;
    CinemachineCameraOffset originalOf;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = cine.GetComponent<CinemachineCameraOffset>();
        originalOf = offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            offset.m_Offset = goalOffsetDown;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            offset = originalOf;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            offset.m_Offset = goalOffsetUp;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            offset = originalOf;
        }
    }


}
