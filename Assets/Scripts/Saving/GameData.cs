using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

[Serializable]
public class GameData
{
    public int difficulty;
    public int level1Index=0;
    public int level2Index=0;
    public bool gameStarted;
    //public Vector3 level1Pos;
    public bool isLevel1Finish;
    public bool level2ExitIndex;
    public bool playerHasDied;

    public float basicLetterDamage;
    public bool isRockLetterSelected;
    public float rockLetterDamage;
    public bool isNormalLetterSelected;
    public bool isFireworkLetterSelected;
    public float fireworkLetterDamage;

    public float duration;
    public float magnitude;
    public float durationSoft;
    public float magnitudeSoft;
    public int buildIndex;
    public bool houseHasBeenBought;
    public bool craftingBenchHasBeenBought;
    public bool fireHasBeenBought;
    public bool mapTableHasBeenBought;
    public bool mapTableUnlock;
    public bool farmHasBeenBought;
    public bool tileHasBeenBought;
    public bool fenceHasBeenBought;
    public bool gateHasBeenBought;
    public bool flowerPotHasBeenBought;
    public bool windmillHasBeenBought;
    public bool hasBeenPlanted1;
    public bool collectFarm1;
    public int maxTime1;
    public int currentTime1;
    public int[] levelChests= new int[30];
    public int level1EnemyCount;
    public bool isLevel2Complete;
    public bool level2EnemyDied;
    public bool island1Unlocked;
    public bool island2Unlocked;
    public bool island3Unlocked;
    public bool isTutorialOver;
    public bool isHomeDone;
    public bool isSoundPaused;

    public int resorsesCount;
    public int stoneCount;
    public int grassCount;
    public int mushroomCount;
    public int stickCount;
    public int ironCount;
    public int ropeCount;
    public int fireworkCount;
    public int goldCount;
    public int eyeTalisman;
    public int slashTalisman;
    public int healthTalisman;
    public int rockLetterCount;
    public int fireworkLetterCount;
    public int plankCount;
    public int bandageCount;
    public int polishRockCount;
    public int greenShroomCount;
    public int seedCount;
    public int tomatoCount;
    public int pumpkinCount;
    public int carrotCount;
    public int cornCount;
    public int boss1CompleteLetter;
    public int boss2CompleteLetter;
    public int boss3CompleteLetter;
    public int cookHat;
    public int collageHat;
    public int japanHat;
    public int cristamsHat;
    public int astronautHat;
    public int partyHat;
    public int fancyHat;
    public int soliderHat;
    public int vikingHat;
    public int mailmanHat;
    public  bool taskDone;
    public  int tokenCount;
   
    public bool questStarted;
    public bool docQuest1;
    public bool docQuest2;
    public bool docQuest3;
    public bool docQuest1IsActive;
    public bool docQuest2IsActive;
    public bool docQuest3IsActive;
    public bool hasGivenTokenDoc;
    public bool catQuest1;
    public bool catQuest2;
    public bool catQuest3;
    public bool catQuest1IsActive;
    public bool catQuest2IsActive;
    public bool catQuest3IsActive;
    public bool crowQuest1;
    public bool crowQuest2;
    public bool crowQuest3;
    public bool crowQuest1IsActive;
    public bool crowQuest2IsActive;
    public bool crowQuest3IsActive;
    public bool hasGivenTokenCrow;
    public bool hasTalkedCrow;
    public int gooldSpent;
    public bool isTwinSaved;
    public bool talisman1Collected;
    public bool isBoss1Defeted;
    public bool isBoss2Defeted;
    public bool isBoss3Defeted;


    // public GameData (GameManager manager){
    //     // level1Index = manager.level1Index;
    //     // level2Index = manager.level2Index;
    //     // gameStarted = manager.gameStarted;
    //     // isLevel1Finish = manager.isLevel1Finish;
    //     // level2ExitIndex = manager.level2ExitIndex;
    //     // playerHasDied = manager.playerHasDied;
    //     // basicLetterDamage = manager.basicLetterDamage;
    //     // isRockLetterSelected = manager.isRockLetterSelected;
    //     // rockLetterDamage = manager.rockLetterDamage;
    //     // isNormalLetterSelected = manager.isRockLetterSelected;
    //     // isFireworkLetterSelected = manager.isFireworkLetterSelected;
    //     // fireworkLetterDamage = manager.fireworkLetterDamage;
    //     // duration=manager.duration;
    //     // magnitude=manager.magnitude;

    // }

}
