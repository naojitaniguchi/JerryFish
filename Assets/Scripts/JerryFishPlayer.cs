using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryFishPlayer : MonoBehaviour
{
    [SerializeField] float jumpPower = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
    }
}
