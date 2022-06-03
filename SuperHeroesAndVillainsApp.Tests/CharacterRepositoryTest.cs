using SuperHeroesAndVillainsApp.Web.Models;
using System.Collections.Generic;
using Xunit;

namespace SupperHeroesAndVillainsApp.Tests
{
    public class CharacterRepositoryTest
    {
        private ICharacterRepository _repository;

        public CharacterRepositoryTest()
        {
            _repository = new FakeCharacterRepository();
        }

        [Fact]
        public void GetCharacterByIdShouldReturnACharacterObject()
        {
            //Arrange
            int characterId = 732 /*1234567*/;

            //Act   
            var result = _repository.GetCharacterById(characterId);

            //Assert
            Assert.IsType<Character>(result.Result);
        }

        [Fact]
        public void GetCharactersByNameShouldReturnSuccessResponseWhenCharactersFound()
        {
            //Arrange
            string characterName = "man";

            //Act
            var result = _repository.GetCharactersByName(characterName);

            //Assert
            Assert.Contains("success", result.Result.Response.ToLower());
        }

        [Fact]
        public void GetCharactersByNameShouldReturnErrorResponseWhenCharactersNotFound()
        {
            //Arrange
            string characterName = "abcd";

            //Act
            var result = _repository.GetCharactersByName(characterName);

            //Assert
            Assert.Contains("error", result.Result.Response.ToLower());
        }

        [Fact]
        public void GetCharactersByNameResponseShouldHaveAListOfCharacterObjectsWhenCharactersFound()
        {
            //Arrange
            string characterName = "iron";

            //Act
            var result = _repository.GetCharactersByName(characterName);

            //Assert
            Assert.IsType<List<Character>>(result.Result.Results);
        }
    }
}
