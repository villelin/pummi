﻿using UnityEngine;
using System.Collections;

public class EscapeController : MonoBehaviour
{
    GameObject inspector;
    GameObject pate;

    float timer;

    const float pate_xleft = -500.0f;
    const float pate_xright = 600.0f;

    bool moving_right;

	// Use this for initialization
	void Start ()
    {
        inspector = GameObject.Find("Inspector");

        moving_right = false;

        GameObject.Find("Music").GetComponent<AudioSource>().Play();
        pate = GameObject.Find("Pate");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 pate_pos = pate.transform.position;

        float inspector_xpos = 0;
        if (moving_right)
        {
            inspector_xpos = pate_pos.x - 100.0f;
        }
        else
        {
            inspector_xpos = pate_pos.x + 100.0f;
        }

        inspector.transform.position = new Vector3(inspector_xpos, pate_pos.y, 0);


	}

    void LeftExitTrigger()
    {
        if (!moving_right)
        {
            moving_right = true;
            float new_ypos = Random.Range(50.0f, 250.0f);
            pate.SendMessage("SetPosition", new Vector2(pate_xleft, new_ypos));
            pate.SendMessage("SetTarget", new Vector2(pate_xright, new_ypos));
        }
    }

    void RightExitTrigger()
    {
        if (moving_right)
        {
            moving_right = false;
            float new_ypos = Random.Range(50.0f, 250.0f);
            pate.SendMessage("SetPosition", new Vector2(pate_xright, new_ypos));
            pate.SendMessage("SetTarget", new Vector2(pate_xleft, new_ypos));
        }
    }
}