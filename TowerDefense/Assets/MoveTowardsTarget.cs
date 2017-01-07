using UnityEngine;
using System.Collections;

public class MoveTowardsTarget : MonoBehaviour {


    // UPGRADABLE
    public float speed = 2;
    public float rotateSpeed = 3;
    public float damage;

    private Rigidbody2D rb;
    private Vector3 movement;
    public GameObject targetObject;
    public Vector3 target;
    private GameObject explosionRadius;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        movement = new Vector3(speed, 0, 0);
    }



    void FixedUpdate()
    {
        target = targetObject.transform.position;

        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        rb.velocity = transform.TransformDirection(new Vector2(speed, 0));

        Vector3 vectorToTarget = target - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9)
        {
            this.gameObject.SetActive(false);

            speed = 0;
        }
    }

}
