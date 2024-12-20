﻿using YavaPrimum.Core.DataBase.Models;
using YavaPrimum.Core.DTO;

namespace YavaPrimum.Core.Interfaces
{
    public interface ICandidateService
    {
        Task<Guid> Create(Candidate candidate);
        Task<List<CandidateRequest>> GetAll();
        Task<Candidate> GetById(Guid id);
        Task<Guid> Create(CandidateRequest candidateRequest);
    }
}