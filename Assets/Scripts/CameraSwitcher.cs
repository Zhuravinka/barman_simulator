using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public static class CameraSwitcher 
{
    private static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();
    
    public static CinemachineVirtualCamera ActiveCamera = null;

    public static void Register(CinemachineVirtualCamera camera)
    {
        
    }
    public static void Unregister(CinemachineVirtualCamera camera)
    {
        
    }

}
