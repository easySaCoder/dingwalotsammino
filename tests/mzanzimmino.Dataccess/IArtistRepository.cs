using System;
using SaLyrics.Entities;

namespace SaLyrics.DataLayer {
    public interface IArtistRepository:IRepository<Artist,Guid> {
    }
}