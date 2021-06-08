using UnityEngine;
using UnityEngine.EventSystems;

public class GameMaster : MonoBehaviour
{
    public Color hoverColor;

    private Renderer rend;
    private Color startColor;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        startColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //gets the location of squares
    void getSquare()
    {

    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
