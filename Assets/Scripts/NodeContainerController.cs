using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NodeContainerController : MonoBehaviour
{

    Vector2 lastMousePos;

    // Start is called before the first frame update
    void Start()
    {
        lastMousePos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        MoveGraph();
        ZoomGraph();
    }

    private void MoveGraph()
    {
        if (Input.GetMouseButton(2))
        {

            Vector2 mousePos = lastMousePos - (Vector2)Input.mousePosition;

            this.transform.position -= (Vector3)mousePos ;

            lastMousePos = Input.mousePosition;
        }
        else
        {
            lastMousePos = Input.mousePosition;
        }
    }

    private void ZoomGraph()
    {
        if(this.transform.localScale.x > 0.3 && this.transform.localScale.x < 3.1)
        this.transform.localScale += Vector3.one * Input.mouseScrollDelta.y * 0.2f;

        this.transform.localScale = new Vector3(Mathf.Clamp(this.transform.localScale.x, 0.4f, 3f), Mathf.Clamp(this.transform.localScale.y, 0.4f, 3f), Mathf.Clamp(this.transform.localScale.z, 0.4f, 3f));
        
    }
}
