using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFloorIce : MonoBehaviour
{

    public GameObject trap;
    
    // Start is called before the first frame update
    public void ActivateTrap()
    {
        trap.SetActive(false);
    }
}
