using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Homework3.Task5.Scripts
{
    public class CharacterSelectionView : MonoBehaviour
    {
        [Header("RaceSelectionButtons")]
        [SerializeField] private GameObject _raceSelectionWindow;
        [SerializeField] private Button _orkSelectionButton;
        [SerializeField] private Button _elfSelectionButton;
        [SerializeField] private Button _humanSelectionButton;
        [Header("ClassSelectionButtons")]
        [SerializeField] private GameObject _classSelectionWindow;
        [SerializeField] private Button _thiefSelectionButton;
        [SerializeField] private Button _mageSelectionButton;
        [SerializeField] private Button _barbarianSelectionButton;
        [Header("AbilitySelectionButtons")]
        [SerializeField] private GameObject _abilitySelectionWindow;
        [SerializeField] private Button _intelegenceSelectionButton;
        [SerializeField] private Button _agilitySelectionButton;
        [SerializeField] private Button _strenghtSelectionButton;

        private PlayerBootstrap _playerBootstrap;
        private Player _player;

        public void Initialize(PlayerBootstrap playerBootstrap)
        {
            _playerBootstrap = playerBootstrap;

            _orkSelectionButton.onClick.AddListener(() => SetPlayerRace(CharacterFactory.RaceType.Ork));
            _elfSelectionButton.onClick.AddListener(() => SetPlayerRace(CharacterFactory.RaceType.Elf));
            _humanSelectionButton.onClick.AddListener(() => SetPlayerRace(CharacterFactory.RaceType.Human));

            _mageSelectionButton.onClick.AddListener(() => SetPlayerClass(CharacterFactory.ClassType.Mage));
            _thiefSelectionButton.onClick.AddListener(() => SetPlayerClass(CharacterFactory.ClassType.Thief));
            _barbarianSelectionButton.onClick.AddListener(() => SetPlayerClass(CharacterFactory.ClassType.Barbarian));

            _intelegenceSelectionButton.onClick.AddListener(() => SetPlayerSkill(CharacterFactory.SkillType.Intelegence));
            _agilitySelectionButton.onClick.AddListener(() => SetPlayerSkill(CharacterFactory.SkillType.Agility));
            _strenghtSelectionButton.onClick.AddListener(() => SetPlayerSkill(CharacterFactory.SkillType.Strenght));
        }

        private void SetPlayerRace(CharacterFactory.RaceType race)
        {
            _playerBootstrap.SetCharacterRace(race);
            _raceSelectionWindow.SetActive(false);
            _classSelectionWindow.SetActive(true);

            _orkSelectionButton.onClick.RemoveAllListeners();
            _elfSelectionButton.onClick.RemoveAllListeners();
            _humanSelectionButton.onClick.RemoveAllListeners();
        }

        private void SetPlayerClass(CharacterFactory.ClassType characterClass)
        {
            _playerBootstrap.SetCharacterClass(characterClass);
            _classSelectionWindow.SetActive(false);
            _abilitySelectionWindow.SetActive(true);

            _mageSelectionButton.onClick.RemoveAllListeners();
            _thiefSelectionButton.onClick.RemoveAllListeners();
            _barbarianSelectionButton.onClick.RemoveAllListeners();
        }

        private void SetPlayerSkill(CharacterFactory.SkillType skill)
        {
            _playerBootstrap.SetCharacterPassiveSkill(skill);
            _abilitySelectionWindow.SetActive(false);

            _intelegenceSelectionButton.onClick.RemoveAllListeners();
            _agilitySelectionButton.onClick.RemoveAllListeners();
            _strenghtSelectionButton.onClick.RemoveAllListeners();
        }
    }
}