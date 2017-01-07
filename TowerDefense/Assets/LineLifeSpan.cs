using UnityEngine;
using System.Collections;

public class LineLifeSpan : MonoBehaviour {

    public float duration = 2f;

    void OnEnable()
    {
        StartCoroutine(Duration());
    }

    private IEnumerator Duration()
    {

        yield return new WaitForSeconds(duration);

        this.gameObject.transform.parent.gameObject.SetActive(false);

    }
}
