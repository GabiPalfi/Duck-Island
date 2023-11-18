using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("Player")]
    // public GameObject deathUI;
    // public GameObject player;
    public static int level1Index=0;
    public static int level2Index=0;
    public static bool gameStarted;
    public static Vector3 level1Pos;
    public static bool isLevel1Finish;
    public static bool level2ExitIndex;
   


    [Header("Bullets")]
    public float basicLetterDamage;
    public static bool isRockLetterSelected;
    public float rockLetterDamage;
    public static bool isNormalLetterSelected;
    public static bool isFireworkLetterSelected;
    public float fireworkLetterDamage;
    

    [Header("CameraShake")]
    public float duration;
    public float magnitude;
    public float durationSoft;
    public float magnitudeSoft;

    [Header("Base")]
    public static bool houseHasBeenBought;
    public static bool craftingBenchHasBeenBought;
    public static bool fireHasBeenBought;
    public static bool mapTableHasBeenBought;
    public static bool mapTableUnlock;
    public static bool farmHasBeenBought;
    public static bool tileHasBeenBought;
    public static bool fenceHasBeenBought;
    public static bool gateHasBeenBought;
    public static bool flowerPotHasBeenBought;
    public static bool windmillHasBeenBought;

    [Header("Farm")]
    public static bool hasBeenPlanted1;
    public static bool collectFarm1;
    public static int maxTime1;
    public static int currentTime1;
    //public static int testCount;

    [Header("Levels")]
    public static int[] levelChests= new int[30];
    public static int level1EnemyCount;
    public static bool isLevel2Complete;
    public static bool level2EnemyDied;
    public static bool island1Unlocked;
    public static bool island2Unlocked;
    //public static Vector3 playerPosition;


    [Header("Resorses")]
    public static int resorsesCount;
    public static int stoneCount;
    public static int grassCount;
    public static int mushroomCount;
    public static int stickCount;
    public static int ironCount;
    public static int ropeCount;
    public static int fireworkCount;
    public static int goldCount;
    public static int eyeTalisman;
    public static int slashTalisman;
    public static int rockLetterCount;
    public static int fireworkLetterCount;
    public static int plankCount;
    public static int bandageCount;
    public static int polishRockCount;
    public static int greenShroomCount;
    public static int seedCount;
    public static int tomatoCount;
    public static int pumpkinCount;
    public static int carrotCount;
    public static int cornCount;

    [Header("Hats")]
    public static int cookHat;
    public static int collageHat;
    public static int japanHat;
    public static int cristamsHat;
    public static int astronautHat;
    public static int partyHat;
    public static int fancyHat;
    public static int soliderHat;
    public static int vikingHat;
    public static int mailmanHat;


    //public static int stoneCount;
    //public static int stoneCount;
    [Header("Quests")]
    public static bool taskDone;
    public static int tokenCount;
   
    public static bool questStarted;


    [Header("Fish")]

    public static bool docQuest1;
    public static bool docQuest2;
    public static bool docQuest3;
    public static bool docQuest1IsActive;
    public static bool docQuest2IsActive;
    public static bool docQuest3IsActive;
    public static bool hasGivenTokenDoc;

    [Header("Cat")]
    public static bool catQuest1;
    public static bool catQuest2;
    public static bool catQuest3;
    public static bool catQuest1IsActive;
    public static bool catQuest2IsActive;
    public static bool catQuest3IsActive;
    public static int gooldSpent;
    public static bool isTwinSaved;
    

   

    [Header("Amulets")]
    //public int localDashActive;
    public static bool talisman1Collected;

    [Header("Bosses")]
    public static bool isBoss1Defeted;
    public static bool isBoss2Defeted;
   
    void Start()
    {
        //eyeTalisman = localDashActive;
        // StartCoroutine(Test());
        
    }

    
    void Update()
    {
        
    }
   
    public void StartGame(){
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name=="Level 6"){
            SceneManager.LoadScene("Level 6");
        }else{
            SceneManager.LoadScene("MainBase");
            level1Index = 0;
        }
        if(scene.name=="Level 8"){
            SceneManager.LoadScene("Level 8");
        }else{
            SceneManager.LoadScene("MainBase");
            level1Index = 0;
        }
       
    }
    
}
