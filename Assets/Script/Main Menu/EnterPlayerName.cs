using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnterPlayerName : MonoBehaviour
{
    public GameObject playButton;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FindObjectOfType<PlayButton>().PlayGame();
        }
    }
}