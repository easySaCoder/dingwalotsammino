using System.Web.Mvc;
using SaLyrics.Entities;

namespace SaLyrics.WebUI.Controllers {
    public class LyricsController : Controller {

        [HttpGet]
        public ActionResult Index() {
            Models.LyricsViewModel DFD = new Models.LyricsViewModel {
                Lyrics = new Lyrics()
            };
            

            return View(DFD);
        }

        [HttpPost]
        public ActionResult Index(SaLyrics.WebUI.Models.LyricsViewModel viewModel){

            TryValidateModel(viewModel);

            return View(viewModel);
        }

    }
}
