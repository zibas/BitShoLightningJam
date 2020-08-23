using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveDown : MonoBehaviour
{
    public float MoveSpeed;
    public Text myText;
    public float BoundY;
    private bool _isAdded = false;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = GameController.Instance.GetRandomString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -MoveSpeed * Time.deltaTime));

        if(!_isAdded && transform.position.y < BoundY)
        {
            Destroy(gameObject);
        }
    }

    public void SetText(string str)
    {
        myText.text = str;
    }

    public void OnButtonPress()
    {
        /*GameController.Instance.UpdateMainString(myText.text);
        Destroy(gameObject);*/
    }

    private void OnMouseDown()
    {
        GameController.Instance.UpdateMainString(myText.text);
        Destroy(gameObject);
    }
}
