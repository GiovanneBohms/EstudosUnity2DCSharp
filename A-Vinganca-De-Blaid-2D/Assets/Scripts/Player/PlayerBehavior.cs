using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    private InputManager inputManager;
    [SerializeField] private float moveSpeed = 5;

    void Start()
    {
        inputManager = new InputManager();
        Debug.Log("Hello world");
    }

    // Update is called once per frame
   private void Update()
    {

        float moveDirection = inputManager.Movement *
        Time.deltaTime * moveSpeed;
        transform.Translate(moveDirection, 0,0);

    }
}
