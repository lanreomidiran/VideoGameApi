using VideoGameApi.Dtos;
using VideoGameApi.Models;

namespace VideoGameApi.Services
{
    public interface IVideoGameCharacterService
    {
        Task <List<CharacterResponse>> GetAllCharactersAsync();
        Task<CharacterResponse?> GetCharacterByIdAsync(int id);
        Task<CharacterResponse> AddCharacterAsync(Character character);
        Task<bool> UpdateCharacterAsync( int id, Character character);
        Task<bool> DeleteCharacterAsync(int id);
    }
}
