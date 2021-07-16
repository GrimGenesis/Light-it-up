using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace levelUnlockSystem
{

    public class LevelSystemManager : MonoBehaviour
    {
        private static LevelSystemManager instance;

        [SerializeField]
        private LevelData levelData;
        public LevelData LevelData { get => levelData; }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    [System.Serializable]

    public class LevelData
    {
        public int lastUnlockedLevel = 0;
        public LevelItem[] levelItemArray;
    }

    [System.Serializable]

    public class LevelItem
    {
        public bool unlocked;
        public int starAchieved;
    }

}
