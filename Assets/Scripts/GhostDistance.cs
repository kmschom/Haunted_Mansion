using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostDistance : MonoBehaviour
{
    private float distance;
    public Text textbox;

    void Start()
    {
        textbox = GetComponent<Text>();
    }

    void FixedUpdate()
    {
        Vector3 ghost = GameObject.FindGameObjectWithTag("Exit").transform.position;
        Vector3 player = GameObject.FindGameObjectWithTag("Player").transform.position;
        distance = Vector3.Dot(ghost, player);
        textbox.text = "distance to exit: " + Mathf.Round(-distance);
    }
}
