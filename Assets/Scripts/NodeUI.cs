using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class NodeUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nodeContent;
    [SerializeField]
    private TextMeshProUGUI nodeName;


    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private GameObject container;

    private Node node;
    private DialogueEditor dialogueEditor;

    private RectTransform canvasRectTransform;
    private Vector2 offset;

    Vector2 lastMousePos;

    void Start()
    {
        canvasRectTransform = canvas.GetComponent<RectTransform>();
    }

    public void Init(Node node)
    {
        this.node = node;
    }

    private void Update()
    {
        if (node != null)
        {
            UpdateUI();
        }
        
    }


    private void UpdateUI()
    {
        nodeContent.text = node.content;
        nodeName.text = node.id;
    }


    public void OnPointerDown(BaseEventData eventData)
    {
        lastMousePos = Input.mousePosition;
    }

    public void DragHandler(BaseEventData eventData)
    {
        if (Input.GetMouseButton(0))
        {

            Vector2 mousePos = lastMousePos - (Vector2)Input.mousePosition;

            this.transform.position -= (Vector3)mousePos ;

            lastMousePos = Input.mousePosition;
        }
    }

    
}
