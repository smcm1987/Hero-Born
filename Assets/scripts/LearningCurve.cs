using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public string FirstName = "Sam";
    public string LastName = "McMurray";
    public int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public bool IsAuthor = true;
   // int explicitType = (int)3.14;
    public bool hasDungeonKey = true;
    public int CurrentGold = 5;
    public string weaponType = "Longsword";
    public bool weaponEquipped = true;
    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";
    public string CharacterAction = "Attack";
    public int DiceRoll = 7;
    public int PlayerLives = 3;
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    Character hero = new();   
    Character heroine = new("Bork");
    Paladin horace = new();
    

    Weapon huntingBow = new("Bow", 105);
   

    List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wizard",
            "Sterling the Knight"
        };
    Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5 },
            {"Antidote", 7},
            {"Aspirin", 1}
        };

    // Start is called before the first frame update
    void Start()
    {
        
        heroine.PrintStatsInfo();
        huntingBow.PrintWeaponStats();
        //issues with reference type (hero should be not assigned, but since both variables are referring to the same place in
        //memory, hero is assigned values from hero2).
        Character hero2 = hero;
        hero2.Name = "Billy Butcher";
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        horace.PrintStatsInfo();
        

        Weapon warBow = huntingBow;
        warBow.Name = "War Bow";
        warBow.Damage = 155;

        Paladin godfrey = new("Godfrey", warBow);
        godfrey.PrintStatsInfo();

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //chain methods together using dot notation to shorten code but beware that readability suffers
        //DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);
        
        //    //ShowMembers(); 

        //    QuestPartyMembers.Add("Raven the Necromancer");
        //    QuestPartyMembers.Insert(1, "Taniff the Thief");
        //    QuestPartyMembers.Remove("Grim the Barbarian");

        //    int numberOfPotions = ItemInventory["Potion"];
        //    //Debug.Log(ItemInventory["Potion"] + "\t" + numberOfPotions);
        //    //Debug.Log("More Potions" + (ItemInventory["Potion"] = 10));

        //    //Debug.Log($"Items : {ItemInventory.Count}");

        //    ItemInventory.Add("Throwing Knife", 3);
        //    ItemInventory["Bandage"] = 15;
        //    if (ItemInventory.ContainsKey("Aspirin"))
        //    {
        //        Debug.Log($"Aspirin in inventory: {ItemInventory["Aspirin"]}");
        //        ItemInventory["Aspirin"] = 3;
        //        Debug.Log($" New Aspirin in inventory: {ItemInventory["Aspirin"]}");
        //    }
        //    ItemInventory.Remove("Antidote");
        //    //Debug.LogFormat($"Bandages: {ItemInventory["Bandage"]}, Throwing Knives: {ItemInventory["Throwing Knife"]}");
        //    //ShowMembers();

        //    int characterLevel = 32;

        //    CurrentAge *= 2;//Debug.Log(30 + 1);
        //    //Debug.Log(CurrentAge + 1);
        //    ComputeAge();
        //    int NextSkillLevel = GenerateCharacter("Spike", characterLevel);
        //    Debug.Log($"New Level is {NextSkillLevel}");
        //    Debug.Log(GenerateCharacter("Warrior", characterLevel));
        //    PrintConsole(GenerateCharacter("Wizard", 999));
        //    RollCall();


        //    if (weaponEquipped)
        //    {
        //        if (weaponType == "Longsword")
        //        {
        //            Debug.Log("You are ready to fight!");
        //        }
        //    } else
        //    {
        //        Debug.Log("Fists won't work against tough armor");
        //    }

        //    if (hasDungeonKey)
        //    {
        //        Debug.Log("You possess the sacred key - Enter");
        //    } else
        //    {
        //        Debug.Log("You have not proven yourself worthy.");
        //    }

        //    if(weaponType != "Longsword")
        //    {
        //        Debug.Log("You don't appear to have the right weapon.");
        //    }

        //    PrintCharacterAction();
        //    Theivery();
        //    OpenTreasureChamber();
        //    RollDice();
        //    ItemCheck();
        //    HealthStatus();
    }

    ///// <summary>
    ///// Computes a modified age integer
    ///// </summary>
    //void ComputeAge()
    //{

    //    Debug.Log(CurrentAge + AddedAge);
    //    Debug.LogFormat("Text goes {0} here and {1}", CurrentAge, FirstName + "." + LastName);
    //    Debug.Log($"Strings like {FirstName + LastName} can be inserted directly");
    //    Debug.Log($"Float is {Pi} but coverted to int is {explicitType}!");

    //}

    //public int GenerateCharacter(string name, int level)
    //{
    //    Debug.Log($"Character:{name} ~ Level {level}");
    //    return level += 5;
    //}

    //public void PrintConsole (int Input)
    //{
    //    Debug.Log(Input);
    //}

    //public void Theivery()
    //{
    //    if(CurrentGold > 50)
    //    {
    //        Debug.Log("Big Money!");
    //    } else if (CurrentGold < 15)
    //    {
    //        Debug.Log("Ain't much to steal");
    //    } else
    //    {
    //        Debug.Log("Your purse is pretty average");
    //    }
    //}

    //public void OpenTreasureChamber()
    //{
    //    if(PureOfHeart && RareItem == "Relic Stone")
    //    {
    //        if (!HasSecretIncantation)
    //        {
    //            Debug.Log("Now what were those magic words???");
    //        } else
    //        {
    //            Debug.Log("The treasure is yours, worthy one!");
    //        }
    //    } else
    //    {
    //        Debug.Log("Come back when you have what it takes");
    //    }
    //}

    //public void PrintCharacterAction()
    //{
    //    switch (CharacterAction)
    //    {
    //        case "Heal":
    //            Debug.Log("Used Potion");
    //            break;
    //        case "Attack":
    //            Debug.Log("To arms!");
    //            break;
    //        default:
    //            Debug.Log("Shields up!");
    //            break;
    //    }

    //}

    //public void RollDice()
    //{
    //    switch (DiceRoll)
    //    {
    //        case 7:
    //        case 15: 
    //            Debug.Log("Decent Damage");
    //            break;
    //        case 20:
    //            Debug.Log("Critical Hit!");
    //            break;
    //        default:
    //            Debug.Log("You missed!");
    //            break;
    //    }

    //}

    //public void ShowMembers()
    //{
    //    Debug.Log("Party Members: ");
    //    for(int i = 0; i < QuestPartyMembers.Count; i++)
    //    {
    //        Debug.LogFormat($"Index: {i}, Member: {QuestPartyMembers[i]}");
    //        if (QuestPartyMembers[i] == "Merlin the Wizard")
    //        {
    //            Debug.Log("You have the wisdom to pursue your objective");
    //        } 
    //    }
    //}

    //public void RollCall()
    //{
    //    foreach (string partyMember in QuestPartyMembers)
    //    {
    //        Debug.Log($"{partyMember}: \"Here!\" ");
    //    }
    //}

    //public void ItemCheck()
    //{
    //    foreach(KeyValuePair<string, int> kvp in ItemInventory)
    //    {
    //        if(kvp.Value > CurrentGold)
    //        {
    //            Debug.Log($"Cannot afford {kvp.Key}. You need {kvp.Value - CurrentGold} gold to purchase this item.");
    //        } else
    //        {
    //            Debug.Log($"You have {CurrentGold} gold, enough to buy {kvp.Key}");
    //        }
    //    }
    //}

    //public void HealthStatus()
    //{
    //    while (PlayerLives > 0)
    //    {
    //        Debug.Log("Still have life to give!");
    //        PlayerLives--;
    //    }
    //    Debug.Log("Player is dead.");
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
