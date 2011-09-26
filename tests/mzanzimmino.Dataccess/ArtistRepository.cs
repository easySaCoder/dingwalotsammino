using System;
using System.Collections.Generic;
using Norm;
using SaLyrics.Common.ConfigurationProvider;
using SaLyrics.Entities;

namespace SaLyrics.DataLayer {
    public  class ArtistRepository : IArtistRepository {

        private readonly IConfigurationProvider configuration;

        public ArtistRepository(IConfigurationProvider configuration){
            this.configuration = configuration;
        }

        /// <summary>
        /// Create a new entry for artist in the data store
        /// </summary>
        /// <param name="entity"></param>
        public void Add(Artist entity){
            var mongoServer = MongoServer;
            using (mongoServer){
                entity.Id = Guid.NewGuid();
                var mongoCollection = mongoServer.GetCollection<Artist>();
                mongoCollection.Save(entity);
            }
        }

        /// <summary>
        /// Find an Artist By  Guid.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Artist FindById(Guid id){
            throw new NotImplementedException();
        }

        public List<Artist> GetAll(){
            throw new NotImplementedException();
        }

        public void Update(Artist entity){
            throw new NotImplementedException();
        }

        public void Delete(Artist entity){
            throw new NotImplementedException();
        }

        private IMongo MongoServer { get { return Mongo.Create(configuration.MongoDbConnectionString); }
        }
    }
}