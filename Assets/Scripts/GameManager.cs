using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class GameManager : MonoBehaviour
{
    private GameData scriptData;
    public static bool saveFileExists;
    public static int difficulty;
    // private bool exists;

    [Header("Player")]
    // public GameObject deathUI;
    // public GameObject player;
    public static int level1Index=0;
    public static int level2Index=0;
    public static bool gameStarted;
    public static Vector3 level1Pos;
    public static bool isLevel1Finish;
    public static bool level2ExitIndex;
    public static bool playerHasDied;
   


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

    public static int buildIndex;
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
    public static bool island3Unlocked;
    public static bool isTutorialOver;
    public static bool isHomeDone;

    public static bool isSoundPaused;
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
    public static int healthTalisman;
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
    public static int boss1CompleteLetter;
    public static int boss2CompleteLetter;
    public static int boss3CompleteLetter;
    public static int boss4CompleteLetter;

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
    public static int dialogueIndexDoc;

    [Header("Cat")]
    public static bool catQuest1;
    public static bool catQuest2;
    public static bool catQuest3;
    public static bool catQuest1IsActive;
    public static bool catQuest2IsActive;
    public static bool catQuest3IsActive;
    public static int gooldSpent;
    public static bool isTwinSaved;
    public static int dialogueIndexCat;


    [Header("Crow")]
    public static bool crowQuest1;
    public static bool crowQuest2;
    public static bool crowQuest3;
    public static bool crowQuest1IsActive;
    public static bool crowQuest2IsActive;
    public static bool crowQuest3IsActive;
    public static bool hasGivenTokenCrow;
    public static bool hasTalkedCrow;
    public static int dialogueIndexCrow;
    public static int questIndexDoc;
    public static int questIndexCat;
    public static int questIndexCrow;

    

   

    [Header("Amulets")]
    //public int localDashActive;
    public static bool talisman1Collected;

    [Header("Bosses")]
    public static bool isBoss1Defeted;
    public static bool isBoss2Defeted;
    public static bool isBoss3Defeted;
    public static bool isLastBossDefeted;
    public static int lastLevelDeathCount;
   
    void Start()
    {
        //eyeTalisman = localDashActive;
        // StartCoroutine(Test());
        playerHasDied=false;
        //tokenCount=3;
    }

    
    void Update()
    {
        // Debug.Log(isBoss1Defeted);
        // Debug.Log(isBoss2Defeted);
        // Debug.Log(isBoss3Defeted);
        // Debug.Log(isLastBossDefeted);
        // if(Input.GetKeyDown(KeyCode.O)){
        //     isBoss1Defeted=true;
        //     isBoss2Defeted=true;
        //     isBoss3Defeted=true;
        //     //isLastBossDefeted=true;
        // }
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
        if(scene.name=="Level 12"){
            lastLevelDeathCount++;
            SceneManager.LoadScene("Level 12");
            
            
        }else{
            SceneManager.LoadScene("MainBase");
            level1Index = 0;
        }
        if(scene.name=="Last Level"){
            SceneManager.LoadScene("Last Level");
        }else{
            SceneManager.LoadScene("MainBase");
            level1Index = 0;
        }
        
       
    }

    private void Awake()
    {
        // Initialize the data class
        scriptData = new GameData();
        IsSaveFileExists();
        //Debug.Log(saveFileExists);
    }

    public void SaveData()
    {
        // Set your variables in the data class
        // scriptData.stoneCount = stoneCount;
        // scriptData.goldCount = goldCount;
        scriptData.difficulty = difficulty;
        scriptData.level1Index = level1Index;
        scriptData.level2Index = level2Index;
        scriptData.gameStarted = gameStarted;
        scriptData.isLevel1Finish = isLevel1Finish;
        scriptData.level2ExitIndex = level2ExitIndex;
        scriptData.playerHasDied = playerHasDied;
        scriptData.basicLetterDamage = basicLetterDamage;
        scriptData.isRockLetterSelected = isRockLetterSelected;
        scriptData.rockLetterDamage = rockLetterDamage;
        scriptData.isNormalLetterSelected = isNormalLetterSelected;
        scriptData.isFireworkLetterSelected = isFireworkLetterSelected;
        scriptData.fireworkLetterDamage = fireworkLetterDamage;
        scriptData.duration = duration;
        scriptData.magnitude=magnitude;
        scriptData.durationSoft=durationSoft;
        scriptData.magnitudeSoft = magnitudeSoft;
        scriptData.buildIndex = buildIndex;
        scriptData.houseHasBeenBought =houseHasBeenBought;
        scriptData.craftingBenchHasBeenBought = craftingBenchHasBeenBought;
        scriptData.fireHasBeenBought = fireHasBeenBought;
        scriptData.mapTableHasBeenBought = mapTableHasBeenBought;
        scriptData.mapTableUnlock = mapTableUnlock;
        scriptData.farmHasBeenBought = farmHasBeenBought;
        scriptData.tileHasBeenBought = tileHasBeenBought;
        scriptData.fenceHasBeenBought = fenceHasBeenBought;
        scriptData.gateHasBeenBought = gateHasBeenBought;
        scriptData.flowerPotHasBeenBought = flowerPotHasBeenBought;
        scriptData.windmillHasBeenBought = windmillHasBeenBought;
        scriptData.hasBeenPlanted1 = hasBeenPlanted1;
        scriptData.collectFarm1 = collectFarm1;
        scriptData.maxTime1 = maxTime1;
        scriptData.currentTime1 = currentTime1;
        scriptData.levelChests = levelChests;
        scriptData.level1EnemyCount = level1EnemyCount;
        scriptData.isLevel2Complete = isLevel2Complete;
        scriptData.level2EnemyDied = level2EnemyDied;
        scriptData.island1Unlocked = island1Unlocked;
        scriptData.island2Unlocked = island2Unlocked;
        scriptData.island3Unlocked = island3Unlocked;
        scriptData.isTutorialOver = isTutorialOver;
        scriptData.isHomeDone = isHomeDone;
        scriptData.isSoundPaused = isSoundPaused;
        scriptData.resorsesCount = resorsesCount;
        scriptData.stoneCount = stoneCount;
        scriptData.grassCount = grassCount;
        scriptData.mushroomCount = mushroomCount;
        scriptData.stickCount = stickCount;
        scriptData.ironCount = ironCount;
        scriptData.ropeCount = ropeCount;
        scriptData.fireworkCount = fireworkCount;
        scriptData.goldCount = goldCount;
        scriptData.eyeTalisman = eyeTalisman;
        scriptData.healthTalisman = healthTalisman;
        scriptData.rockLetterCount = rockLetterCount;
        scriptData.fireworkLetterCount = fireworkLetterCount;
        scriptData.plankCount = plankCount;
        scriptData.bandageCount = bandageCount;
        scriptData.polishRockCount = polishRockCount;
        scriptData.greenShroomCount = greenShroomCount;
        scriptData.seedCount = seedCount;
        scriptData.tomatoCount = tomatoCount;
        scriptData.pumpkinCount = pumpkinCount;
        scriptData.carrotCount = carrotCount;
        scriptData.cornCount= cornCount;
        scriptData.boss1CompleteLetter = boss1CompleteLetter;
        scriptData.boss2CompleteLetter = boss2CompleteLetter;
        scriptData.boss3CompleteLetter=boss3CompleteLetter;
        scriptData.cookHat = cookHat;
        scriptData.collageHat = collageHat;
        scriptData.japanHat = japanHat;
        scriptData.cristamsHat = cristamsHat;
        scriptData.astronautHat = astronautHat;
        scriptData.partyHat = partyHat;
        scriptData.fancyHat = fancyHat;
        scriptData.soliderHat = soliderHat;
        scriptData.vikingHat = vikingHat;
        scriptData.mailmanHat = mailmanHat;
        scriptData.taskDone = taskDone;
        scriptData.tokenCount = tokenCount;
        scriptData.questStarted = questStarted;
        scriptData.docQuest1 =docQuest1;
        scriptData.docQuest2 = docQuest2;
        scriptData.docQuest3 = docQuest3;
        scriptData.docQuest1IsActive = docQuest1IsActive;
        scriptData.docQuest2IsActive = docQuest2IsActive;
        scriptData.docQuest3IsActive = docQuest3IsActive;
        scriptData.hasGivenTokenDoc = hasGivenTokenDoc;
        scriptData.catQuest1 = catQuest1;
        scriptData.catQuest2 = catQuest2;
        scriptData.catQuest3 = catQuest3;
        scriptData.catQuest1IsActive = catQuest1IsActive;
        scriptData.catQuest2IsActive = catQuest2IsActive;
        scriptData.catQuest3IsActive = catQuest3IsActive;
        scriptData.gooldSpent = gooldSpent;
        scriptData.isTwinSaved = isTwinSaved;
        scriptData.crowQuest1 = crowQuest1;
        scriptData.crowQuest2 = crowQuest2;
        scriptData.crowQuest3 = crowQuest3;
        scriptData.crowQuest1IsActive = crowQuest1IsActive;
        scriptData.crowQuest2IsActive = crowQuest2IsActive;
        scriptData.crowQuest3IsActive = crowQuest3IsActive;
        scriptData.hasGivenTokenCrow = hasGivenTokenCrow;
        scriptData.hasTalkedCrow = hasTalkedCrow;
        scriptData.isBoss1Defeted = isBoss1Defeted;
        scriptData.isBoss2Defeted = isBoss2Defeted;
        scriptData.isBoss3Defeted = isBoss3Defeted;
        scriptData.dialogueIndexDoc = dialogueIndexDoc;
        scriptData.dialogueIndexCat = dialogueIndexCat;
        scriptData.dialogueIndexCrow = dialogueIndexCrow;
        scriptData.questIndexDoc = questIndexDoc;
        scriptData.questIndexCat = questIndexCat;
        scriptData.questIndexCrow = questIndexCrow;

        // Set other variables as needed

        // Set the path where you want to save the file
        string filePath = Application.persistentDataPath + "/savedData.dat";

        // Serialize and save the data to a file
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, scriptData);
                Debug.Log("Data saved successfully.");
            }
            catch (SerializationException e)
            {
                Debug.LogError("Failed to serialize data: " + e.Message);
            }
        }
    }
    public void LoadData()
    {
        // Set the path where you saved the file
        string filePath = Application.persistentDataPath + "/savedData.dat";

        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Deserialize and load the data from the file
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    scriptData = (GameData)binaryFormatter.Deserialize(fileStream);
                    Debug.Log("Data loaded successfully.");

                    // Access your variables using scriptData.variable1, scriptData.variable2, etc.
                    // stoneCount = scriptData.stoneCount;
                    // goldCount = scriptData.goldCount;
                    difficulty = scriptData.difficulty;
                    level1Index = scriptData.level1Index;
                    level2Index=scriptData.level2Index;
                    gameStarted = scriptData.gameStarted;
                    isLevel1Finish =scriptData.isLevel1Finish;
                    level2ExitIndex =scriptData.level2ExitIndex;
                    playerHasDied = scriptData.playerHasDied;
                    basicLetterDamage = scriptData.basicLetterDamage;
                    isRockLetterSelected=scriptData.isRockLetterSelected;
                    rockLetterDamage=scriptData.rockLetterDamage;
                    isNormalLetterSelected=scriptData.isNormalLetterSelected;
                    isFireworkLetterSelected=scriptData.isFireworkLetterSelected;
                    fireworkLetterDamage=scriptData.fireworkLetterDamage;
                    duration=scriptData.duration;
                    magnitude=scriptData.magnitude;
                    durationSoft=scriptData.durationSoft;
                    magnitudeSoft=scriptData.magnitudeSoft;
                    buildIndex=scriptData.buildIndex;
                    houseHasBeenBought=scriptData.houseHasBeenBought;
                    craftingBenchHasBeenBought=scriptData.craftingBenchHasBeenBought;
                    fireHasBeenBought=scriptData.fireHasBeenBought;
                    mapTableHasBeenBought=scriptData.mapTableHasBeenBought;
                    mapTableUnlock=scriptData.mapTableUnlock;
                    farmHasBeenBought=scriptData.farmHasBeenBought;
                    tileHasBeenBought=scriptData.tileHasBeenBought;
                    fenceHasBeenBought=scriptData.fenceHasBeenBought;
                    gateHasBeenBought=scriptData.gateHasBeenBought;
                    flowerPotHasBeenBought=scriptData.flowerPotHasBeenBought;
                    windmillHasBeenBought=scriptData.windmillHasBeenBought;
                    hasBeenPlanted1=scriptData.hasBeenPlanted1;
                    collectFarm1=scriptData.collectFarm1;
                    maxTime1=scriptData.maxTime1;
                    currentTime1=scriptData.currentTime1;
                    levelChests=scriptData.levelChests;
                    level1EnemyCount=scriptData.level1EnemyCount;
                    isLevel2Complete=scriptData.isLevel2Complete;
                    level2EnemyDied=scriptData.level2EnemyDied;
                    island1Unlocked=scriptData.island1Unlocked;
                    island2Unlocked=scriptData.island2Unlocked;
                    island3Unlocked=scriptData.island3Unlocked;
                    isTutorialOver=scriptData.isTutorialOver;
                    isHomeDone=scriptData.isHomeDone;
                    isSoundPaused=scriptData.isSoundPaused;
                    resorsesCount=scriptData.resorsesCount;
                    stoneCount=scriptData.stoneCount;
                    grassCount=scriptData.grassCount;
                    mushroomCount=scriptData.mushroomCount;
                    stickCount=scriptData.stickCount;
                    ironCount=scriptData.ironCount;
                    ropeCount=scriptData.ropeCount;
                    fireworkCount=scriptData.fireworkCount;
                    goldCount=scriptData.goldCount;
                    eyeTalisman=scriptData.eyeTalisman;
                    healthTalisman=scriptData.healthTalisman;
                    rockLetterCount=scriptData.rockLetterCount;
                    fireworkLetterCount=scriptData.fireworkLetterCount;
                    plankCount=scriptData.plankCount;
                    bandageCount=scriptData.bandageCount;
                    polishRockCount=scriptData.polishRockCount;
                    greenShroomCount=scriptData.greenShroomCount;
                    seedCount=scriptData.seedCount;
                    tomatoCount=scriptData.tomatoCount;
                    pumpkinCount=scriptData.pumpkinCount;
                    carrotCount=scriptData.carrotCount;
                    cornCount=scriptData.cornCount;
                    boss1CompleteLetter=scriptData.boss1CompleteLetter;
                    boss2CompleteLetter=scriptData.boss2CompleteLetter;
                    boss3CompleteLetter=scriptData.boss3CompleteLetter;
                    cookHat=scriptData.cookHat;
                    collageHat=scriptData.collageHat;
                    japanHat=scriptData.japanHat;
                    cristamsHat=scriptData.cristamsHat;
                    astronautHat=scriptData.astronautHat;
                    partyHat=scriptData.partyHat;
                    fancyHat=scriptData.fancyHat;
                    soliderHat=scriptData.soliderHat;
                    vikingHat=scriptData.vikingHat;
                    mailmanHat=scriptData.mailmanHat;
                    taskDone=scriptData.taskDone;
                    tokenCount=scriptData.tokenCount;
                    questStarted=scriptData.questStarted;
                    docQuest1=scriptData.docQuest1;
                    docQuest2=scriptData.docQuest2;
                    docQuest3=scriptData.docQuest3;
                    docQuest1IsActive=scriptData.docQuest1IsActive;
                    docQuest2IsActive=scriptData.docQuest2IsActive;
                    docQuest3IsActive=scriptData.docQuest3IsActive;
                    hasGivenTokenDoc=scriptData.hasGivenTokenDoc;
                    catQuest1=scriptData.catQuest1;
                    catQuest2=scriptData.catQuest2;
                    catQuest3=scriptData.catQuest3;
                    catQuest1IsActive=scriptData.catQuest1IsActive;
                    catQuest2IsActive=scriptData.catQuest2IsActive;
                    catQuest3IsActive=scriptData.catQuest3IsActive;
                    gooldSpent=scriptData.gooldSpent;
                    isTwinSaved=scriptData.isTwinSaved;
                    isBoss1Defeted=scriptData.isBoss1Defeted;
                    isBoss2Defeted=scriptData.isBoss2Defeted;
                    isBoss3Defeted=scriptData.isBoss3Defeted;
                    dialogueIndexDoc = scriptData.dialogueIndexDoc;
                    dialogueIndexCat = scriptData.dialogueIndexCat;
                    dialogueIndexCrow = scriptData.dialogueIndexCrow;
                    hasGivenTokenCrow = scriptData.hasGivenTokenCrow;
                    hasTalkedCrow = scriptData.hasTalkedCrow;
                    questIndexDoc = scriptData.questIndexDoc;
                    questIndexCat = scriptData.questIndexCat;
                    questIndexCrow = scriptData.questIndexCrow;
                    crowQuest1IsActive = scriptData.crowQuest1IsActive;
                    crowQuest2IsActive = scriptData.crowQuest2IsActive;
                    crowQuest3IsActive = scriptData.crowQuest3IsActive;
                }
                catch (SerializationException e)
                {
                    Debug.LogError("Failed to deserialize data: " + e.Message);
                }
            }
        }
        else
        {
            Debug.LogWarning("No saved data found.");
        }
    }
    public void DeleteSave()
    {
        string filePath = Application.persistentDataPath + "/savedData.dat";

        // Check if the file exists before attempting to delete
        if (File.Exists(filePath))
        {
            try
            {
                File.Delete(filePath);
                Debug.Log("Save file deleted successfully.");
            }
            catch (IOException  ex)
            {
                Debug.LogError("Failed to delete save file: " + ex.Message);
            }
        }
        else
        {
            Debug.LogWarning("No save file found to delete.");
        }
    }
    public void IsSaveFileExists()
    {
        string filePath = Application.persistentDataPath + "/savedData.dat";
        saveFileExists = File.Exists(filePath);
        
    }

    
}
