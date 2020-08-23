using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject WordButtonPrefab;
    public GameObject CanvasObj;
    public float startY = 15;
    public Text MainText;
    private string[] _wordList;
    public float TextScrollSpeed;
    public float SpawnDelay;
    public float SpawnRadius;

    private List<GameObject> _wordStuffs;


    public static GameController Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        _wordList = new string[] {
            "Traveled",
            "Mountains",
            "Snowing",
            "Tragically",
            "They",
            "The",
            "He",
            "She",
            "Melodically",
            "Odiously",
            "Journeyed",
            "Forlorn",
            "Road",
            "Trees",
            "Woods",
            "Forest",
            "Roads",
            "Oak",
            "Bumbling",
            "Bip",
            "Bopply",
            "Bingus",
            "Morply",
            "Slommtus",
            "Lofflor",
            "Spinch",
            "Bubger",
            "Kirg",
            "Sbubby",
            "But",
            "However",
            "Instead",
            "Understood",
            "Mystery",
            "Droppo",
            "Chumbletron",
            "Magical",
            "Moffett",
            "Forgot",
            "Remembered",
            "Lost",
            "Without",
            "Not",
            "Did",
            "Where",
            "Undergrowth",
            "Trodden",
            "Equally",
            "Slumber",
            "Diverged",
            "Less",
            "Greater",
            "Powerful",
            "And",
            "Because",
            "Love",
            "Tragedy",
            "Ages",
            "Hence",
            "Henceforward",
            "Wingler",
            "Robus",
            "Cremslan",
            "Dorbindy",
            "Pumbly",
            "Plumble",
            "Pennythorpe",
            "Ogilvie",
            "Sigh",
            "Sighing",
            "Doubt",
            "Doubted",
            "Difference",
            "All",
            "Equally",
            "Lay",
            "Pry",
            "Fly",
            "Deathly",
            "Ghost",
            "Fog",
            "Wither",
            "Withered",
            "Lubly",
            "Jimbly",
            "Joyous",
            "Joyously",
            "Sixth",
            "Robert",
            "Frost",
            "Frosted",
            "Tips",
            "Trodden",
            "Wear",
            "Wanted",
            "Into",
            "Perhaps",
            "Better",
            "Claim",
            "Having",
            "Fair",
            "Just",
            "In",
            "With",
            "Why",
            "Passing",
            "There",
            "Stood",
            "Long",
            "Somewhere",
            "River",
            "Stream",
            "Sky",
            "Clouds",
            "Gray",
            "Foreboding",
            "Dreadful",
            "Dread",
            "Dreading",
            "Respite",
            "Restful",
            "Rest",
            "Yours",
            "Your",
            "Mine",
            "Myself",
            "Unwelcome",
            "Welcoming",
            "Questioning",
            "Thoughtful",
            "Thoughts",
            "Thought",
            "Plethora",
            "Plumb",
            "Depths",
            "Deep",
            "Dormant",
            "Desire",
            "Be",
            "Or",
            "For",
            "Shall",
            "Visits",
            "Once",
            "Year",
            "My",
            "Him",
            "His",
            "Their",
            "Theirs",
            "They’re",
            "Her",
            "Hers",
            "Regrettable",
            "Forever",
            "Forlorn",
            "Forgotten",
            "Remembered",
            "Recalled",
            "Revitalized",
            "Ribly",
            "Opening",
            "Open",
            "Flight",
            "Ascended",
            "Descended",
            "Ascend",
            "Descend",
            "Eternal",
            "On",
            "Underneath",
            "Conjuring",
            "Original",
            "Ought",
            "To",
            "Know",
            "Prestidigitation",
            "Defy",
            "Never",
            "Ever",
            "Clever",
            "Illumination",
            "Conjuration",
            "Away",
            "Astray",
            "Belay",
            "Vie",
            "Ply",
            "Fry",
            "Fly",
            "Vying",
            "Frying",
            "Flying",
            "Sighing",
            "Plying",
            "Trying",
            "Dying",
            "Driving",
            "West",
            "East",
            "North",
            "Egglington",
        };
        StartCoroutine("MakeWords");
    }

    // Update is called once per frame
    void Update()
    {
        MainText.gameObject.transform.Translate(new Vector2(TextScrollSpeed * Time.deltaTime, 0));
    }

    public IEnumerator MakeWords()
    {
        while(true)
        {
            //Make 2 words (roughly left and right)
            MakeWord(UnityEngine.Random.Range(-SpawnRadius, 0));
            MakeWord(UnityEngine.Random.Range(0, SpawnRadius), 0.5f);

            yield return new WaitForSeconds(SpawnDelay);
        }
    }

    public string GetRandomString()
    {
        return _wordList[UnityEngine.Random.Range(0, _wordList.Length)];
    }

    public void UpdateMainString(string addStr)
    {
        MainText.text = MainText.text + " " +  addStr;
    }

    void MakeWord(float randX, float adjustY = 0f)
    {
        GameObject newWordButton = Instantiate(WordButtonPrefab, CanvasObj.transform);
        newWordButton.transform.position = new Vector2(randX, startY + adjustY);
    }
}
