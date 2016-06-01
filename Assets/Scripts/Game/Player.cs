using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    Animator animator;
    Rigidbody2D rb;
    float minX, maxX;
	void Start () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        transform.localScale = new Vector3(3f, 3f, 3f);

	}
    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
#if UNITY_EDITOR
        print("unity :V");
#endif
    }
	
	// Update is called once per frame
	void Update () {
        float dir = Input.acceleration.x;
        float forceX = 0f;
        if (dir > 0.1f)
        {
            forceX = 2f;
        } else if (dir < -0.1f)
        {
            forceX = -2f;
        }
        rb.velocity = new Vector2(forceX, rb.velocity.y);
    }
}
