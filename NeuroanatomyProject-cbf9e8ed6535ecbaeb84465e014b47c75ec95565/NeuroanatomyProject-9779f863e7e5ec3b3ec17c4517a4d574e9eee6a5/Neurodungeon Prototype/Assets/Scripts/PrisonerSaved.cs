using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonerSaved : MonoBehaviour
{
    public Transform waypoint;

    public void OnSaving ()
    {
        transform.position = waypoint.position;
    }
}
