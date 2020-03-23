using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{//Private means: No reason to access the script in Unity
    private Rigidbody PlayerRigidbody;
    public float forceMultiplier;
    public float gravityMultiplier;
    public bool onGround = true;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround )
        { PlayerRigidbody.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse);
            onGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;

    }
}
