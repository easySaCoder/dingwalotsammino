using NUnit.Framework;
using SaLyrics.Common.ConfigurationProvider;
using SaLyrics.DataLayer;
using SaLyrics.Entities;

namespace SaLyrics.DataAccesslayerTests {

    [TestFixture]
    public class ArtistRepositoryTests {


        [Test]
        public void Add_Make_sure_It_Is_Working() {

            ArtistRepository artistRepository = new ArtistRepository(new ConfigurationProvider());

            Artist artist = new Artist {
                Albums = new System.Collections.Generic.List<Album>{
                                                                                                 new Album{
                                                                                                              Title="Reasonable dought"
                                                                                                              ,
                                                                                                              Tracks= new System.Collections.Generic.List<Track>{
                                                                                                                     new Track{
                                                                                                                               Number=1,
                                                                                                                               title="Dead president"
                                                                                                                              }                                                      
                                                                                                              }, YearReleased=1996
                                                                                                          },
                                                                   }
            };

            artistRepository.Add(artist);

            Assert.That(artist.Id,Is.Not.Null);
        }
    }
}