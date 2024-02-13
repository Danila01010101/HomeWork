using UnityEngine;

namespace Assets.Homework3.Task5.Scripts
{
    public class PlayerBootstrap : MonoBehaviour
    {
        [SerializeField] private LevelData _levelData;
        [SerializeField] private CharacterSelectionView _characterSelectionView;

        private Player _player;
        private CharacterFactory _characterFactory;
        private CharacterFactory.RaceType _race;
        private CharacterFactory.ClassType _class;
        private CharacterFactory.SkillType _skill;

        private void Awake()
        {
            _characterSelectionView.Initialize(this);
            _characterFactory = new CharacterFactory(_levelData);
        }

        public void SetCharacterRace(CharacterFactory.RaceType race) => _race = race;
        public void SetCharacterClass(CharacterFactory.ClassType characterClass) => _class = characterClass;
        public void SetCharacterPassiveSkill(CharacterFactory.SkillType skill)
        {
            IStatsProvider stats = _characterFactory.GetStats(_race, _class, skill);
            _player = new Player(stats);
        }
    }
}