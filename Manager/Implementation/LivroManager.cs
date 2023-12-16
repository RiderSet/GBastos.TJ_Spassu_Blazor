﻿using Domain.Entities;
using Manager.Interfaces;

namespace Manager.Implementation
{
    public class LivroManager : ILivroManager
    {
        private readonly ILivroRepository _repository;

        public LivroManager(ILivroRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Livro>> GetLivrosAsync()
        { 
            return await _repository.GetLivrosAsync();
        }

        public async Task<Livro> GetLivroAsync(int codl)
        {
            return await _repository.GetLivroAsync(codl);
        }

        public async Task DeleteLivroAsync(int codl)
        {
            await _repository.DeleteLivroAsync(codl);
        }

        public async Task<Livro> InsertLivroAsync(Livro livro)
        {
            return await _repository.InsertLivroAsync(livro);
        }

        public async Task<Livro> UpdateLivroAsync(Livro livro)
        {
            return await _repository.UpdateLivroAsync(livro);
        }
    }
}