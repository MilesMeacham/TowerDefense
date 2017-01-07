using UnityEngine;
using System.Collections;

public class LineCollisionDetection : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 10)
        {
            this.gameObject.transform.parent.gameObject.SetActive(false);

        }
    }
}
