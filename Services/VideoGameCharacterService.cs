using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VideoGameApi.Data;
using VideoGameApi.Dtos;
using VideoGameApi.Models;

namespace VideoGameApi.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
    {
        public async Task<CharacterResponse> AddCharacterAsync(CreateCharacterRequest character)
        {
            var newCharacter = new Character
            {
                Name = character.Name,
                Game = character.Game,
                Role = character.Role,
            };
            context.Characters.Add(newCharacter);
            await context.SaveChangesAsync();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CharacterResponse>> GetAllCharactersAsync()
         => await context.Characters.Select(c=> new CharacterResponse
         {
             Id = c.Id,
             Name = c.Name,
             Game = c.Game,
             Role = c.Role,
         }).ToListAsync();

        public async Task<CharacterResponse?> GetCharacterByIdAsync(int id)
        {
            var result = await context.Characters
                .Where(c => c.Id == id)
                .Select(c => new CharacterResponse
                {
                    Name = c.Name,
                    Game = c.Game,
                    Role = c.Role,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        public Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequest character)
        {
            throw new NotImplementedException();
        }

        Task<CharacterResponse> IVideoGameCharacterService.AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        Task<List<CharacterResponse>> IVideoGameCharacterService.GetAllCharactersAsync()
        {
            throw new NotImplementedException();
        }

        Task<CharacterResponse?> IVideoGameCharacterService.GetCharacterByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
