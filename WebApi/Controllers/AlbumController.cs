using Entities.POCOEntities;
using Microsoft.AspNetCore.Mvc;
using Presenters.ListAlbum;
using UseCasesPorts.ListAlbum;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : Controller
    {

        readonly IListAlbumInputPort ListAlbumInputPort;
        readonly IListAlbumOutputPort ListAlbumOutputPort;

        public AlbumController(IListAlbumInputPort listAlbumInputPort, IListAlbumOutputPort listAlbumOutputPort) =>
                (ListAlbumInputPort, ListAlbumOutputPort) = (listAlbumInputPort, listAlbumOutputPort);


        [HttpGet]
        public async Task<IEnumerable<Album>> GetAlbums()
        {

            await ListAlbumInputPort.GetAlbums();

            var Presenter = ListAlbumOutputPort as ListAlbumPresenter;

            return Presenter.Content;
        }


    }
}
