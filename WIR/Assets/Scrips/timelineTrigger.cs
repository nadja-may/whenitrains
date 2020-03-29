using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public bool played = false;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (!played)
            {
                played = true;
                timeline.Play();
            }
        }
    }
}
