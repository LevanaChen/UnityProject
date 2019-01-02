using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARExtensions;

public class ARSessionVerification : MonoBehaviour
{
    private bool m_Verified = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_Verified && ARSubsystemManager.systemState >= ARSystemState.Ready)
        {
            Debug.Log("ARSessionVerification: " + ARSubsystemManager.sessionSubsystem);
            Debug.Log("ARSessionVerification: " + ARSubsystemManager.sessionSubsystem.GetNativePtr());

            m_Verified = true;
        }

    }
}
