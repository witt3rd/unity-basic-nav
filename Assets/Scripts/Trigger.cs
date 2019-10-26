using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    public PlayableDirector director;

    private void OnMouseDown()
    {
        director.Play();
    }
}
