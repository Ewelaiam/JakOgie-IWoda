using System.Collections.Generic;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public RoadManager roadManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            roadManager.AddNewSection();
        }
    }
}