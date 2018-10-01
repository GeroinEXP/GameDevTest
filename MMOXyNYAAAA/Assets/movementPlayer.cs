using System.Collections;
using UnityEngine;

public class movementPlayer : MonoBehaviour {

    public float speed = 6.0f;
    Vector3 position1;

    void Start ()
    {
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                position1 = hit.point;
            }
            Vector3 direction = position1 - transform.position;
            float targ_pos = Vector3.Distance(transform.position, position1);

            if (targ_pos > 1)
            {
                transform.Translate(direction * speed, Space.World);
            }
        }
    }
}
