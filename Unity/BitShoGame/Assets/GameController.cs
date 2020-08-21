using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject WordButtonPrefab;

    private List<GameObject> _wordStuffs;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(WordButtonPrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
