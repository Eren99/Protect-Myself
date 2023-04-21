using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    public float backGroundSpeed;
    public Renderer backGroundRenderer;

    // Auto Update Renderer
    private void Start()
    {
        backGroundRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        backGroundRenderer.material.mainTextureOffset += new Vector2(backGroundSpeed * Time.deltaTime, 0);
    }
}
