using SuperHeroesAndVillainsApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SupperHeroesAndVillainsApp.Tests
{
    public class FakeCharacterRepository : ICharacterRepository
    {
        private List<Character> _characters = new List<Character>();

        public FakeCharacterRepository()
        {
            _characters = GetMockedCharacterList();
        }

        public async Task<Character> GetCharacterById(int id)
        {
            Character character = new Character();
            character = _characters.Where(c => c.Id == id).DefaultIfEmpty(character).First();
            return character;
        }

        public async Task<SearchResponseViewModel> GetCharactersByName(string name)
        {
            SearchResponseViewModel responseViewModel = new SearchResponseViewModel();
            var characters = _characters.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();
            if (characters.Any())
            {
                responseViewModel.Response = "Success";
                responseViewModel.Error = "";
                responseViewModel.Results = characters;
            }
            else
            {
                responseViewModel.Response = "Error";
                responseViewModel.Error = "Character with given name not found";
            }
            return responseViewModel;
        }

        public List<Character> GetMockedCharacterList()
        {
            var characterList = new List<Character>
            {
                new Character {
                    Id = 732, Name = "IronMan",
                    Appearance = new CharacterAppearance
                    {
                        EyeColor = "Blue",
                        Gender = "Male",
                        HairColor = "Black",
                        Race = "Human",
                        Height = new List<string> { "6'6", "198 cm" },
                        Weight = new List<string> { "425 lb", "191 kg" },
                    },
                    Image = new CharacterImage { Url = "https://www.superherodb.com/pictures2/portraits/10/100/85.jpg" },
                    Biography = new CharacterBiography {
                        FullName = "Tony Stark",
                        AlterEgos = "No alter egos found.",
                        Aliases = new List<string> { "Iron Knight", "Ironman" },
                        Alignment = "Good",
                        FirstAppearance = "Tales of Suspence #39 (March, 1963)",
                        PlaceOfBirth = "Long Island, New York",
                        Publisher = "Marvel Comics"
                    },
                    Powerstats = new CharacterPowerstats {
                        Intelligence = "100",
                        Strength = "85",
                        Durability = "85",
                        Speed = "58",
                        Power = "100",
                        Combat = "64"
                    }
                },
                new Character
                {
                    Id = 720, Name = "Wonder Woman",
                    Appearance = new CharacterAppearance
                    {
                        EyeColor = "Blue",
                        Gender = "Female",
                        HairColor = "Black",
                        Race = "Human",
                        Height = new List<string> { "6'0,", "183 cm" },
                        Weight = new List<string> { "165 lb", "74 kg" },
                    },
                    Image = new CharacterImage { Url = "https://www.superherodb.com/pictures2/portraits/10/100/807.jpg" },
                    Biography = new CharacterBiography {
                        FullName = "Diana Prince",
                        AlterEgos = "No alter egos found.",
                        Aliases = new List<string> { "Princess Diana", "Princess of the Amazons" },
                        Alignment = "Good",
                        FirstAppearance = "All-Star Comics #8 (December, 1941)",
                        PlaceOfBirth = "Themyscira",
                        Publisher = "DC Comics"
                    },
                    Powerstats = new CharacterPowerstats {
                        Intelligence = "88",
                        Strength = "100",
                        Durability = "100",
                        Speed = "79",
                        Power = "100",
                        Combat = "100"
                    }
                },
                new Character
                {
                    Id = 644, Name = "Superman",
                    Appearance = new CharacterAppearance
                    {
                        EyeColor = "Blue",
                        Gender = "Female",
                        HairColor = "Black",
                        Race = "Kryptonian",
                        Height = new List<string> { "6'3,", "191 cm" },
                        Weight = new List<string> { "225 lb", "101 kg" },
                    },
                    Image = new CharacterImage { Url = "https://www.superherodb.com/pictures2/portraits/10/100/791.jpg" },
                    Biography = new CharacterBiography {
                        FullName = "Clark Kent",
                        AlterEgos = "Superman Prime One-Million",
                        Aliases = new List<string> { "Clark Joseph Kent", "The Man of Steel" },
                        Alignment = "Good",
                        FirstAppearance = " ACTION COMICS #1",
                        PlaceOfBirth = "Krypton",
                        Publisher = " Superman Prime One-Million"
                    },
                    Powerstats = new CharacterPowerstats {
                        Intelligence = "94",
                        Strength = "100",
                        Durability = "100",
                        Speed = "100",
                        Power = "100",
                        Combat = "85"
                    }
                }
            };

            return characterList;
        }
    }
}
