using System;

namespace Assets.Homework3.Task5.Scripts
{
    public class CharacterFactory
    {
        private LevelData _levelData;

        public enum RaceType { Ork, Elf, Human, None }
        public enum ClassType { Thief, Mage, Barbarian, None }
        public enum SkillType { Agility, Strenght, Intelegence, None }

        public CharacterFactory(LevelData levelData)
        {
            _levelData = levelData;
        }

        public IStatsProvider GetStats(RaceType raceType, ClassType classType, SkillType skillType)
        {
            IStatsProvider characterStats;

            switch (raceType)
            {
                case (RaceType.Ork):
                    characterStats = new RaceStats(_levelData.OrkStartStats);
                    break;

                case (RaceType.Elf):
                    characterStats = new RaceStats(_levelData.ElfStartStats);
                    break;

                case (RaceType.Human):
                    characterStats = new RaceStats(_levelData.HumanStartStats);
                    break;

                default:
                    throw new ArgumentException();
            }

            switch (classType)
            {
                case (ClassType.Mage):
                    characterStats = new ClassStatsProvider(characterStats, _levelData.MageStats);
                    break;

                case (ClassType.Barbarian):
                    characterStats = new ClassStatsProvider(characterStats, _levelData.ElfStartStats);
                    break;

                case (ClassType.Thief):
                    characterStats = new ClassStatsProvider(characterStats, _levelData.HumanStartStats);
                    break;

                default:
                    throw new ArgumentException();
            }

            switch (skillType)
            {
                case (SkillType.Intelegence):
                    characterStats = new PassiveAbilityStats(characterStats, _levelData.InteligenceStats);
                    break;

                case (SkillType.Strenght):
                    characterStats = new PassiveAbilityStats(characterStats, _levelData.StrenghtStats);
                    break;

                case (SkillType.Agility):
                    characterStats = new PassiveAbilityStats(characterStats, _levelData.AgilityStartStats);
                    break;

                default:
                    throw new ArgumentException();
            }

            return characterStats;
        }
    }
}