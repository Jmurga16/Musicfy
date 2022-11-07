using Entities.POCOEntities;
using Microsoft.AspNetCore.Mvc;
using Presenters.FormAlbum;
using Presenters.ListAlbum;
using UseCasesDTOs.FormAlbum;
using UseCasesPorts.FormAlbum;
using UseCasesPorts.ListAlbum;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : Controller
    {

        readonly IListAlbumInputPort ListAlbumInputPort;
        readonly IListAlbumOutputPort ListAlbumOutputPort;

        readonly ICreateAlbumInputPort CreateInputPort;
        readonly ICreateAlbumOutputPort CreateOutputPort;

        readonly IUpdateAlbumInputPort UpdateInputPort;
        readonly IUpdateAlbumOutputPort UpdateOutputPort;

        readonly IDeleteAlbumInputPort DeleteInputPort;
        readonly IDeleteAlbumOutputPort DeleteOutputPort;

        public AlbumController(IListAlbumInputPort listAlbumInputPort, IListAlbumOutputPort listAlbumOutputPort,
            ICreateAlbumInputPort createInputPort, ICreateAlbumOutputPort createOutputPort,
            IUpdateAlbumInputPort updateInputPort, IUpdateAlbumOutputPort updateOutputPort,
            IDeleteAlbumInputPort deleteInputPort, IDeleteAlbumOutputPort deleteOutputPort) =>
                (ListAlbumInputPort, ListAlbumOutputPort, CreateInputPort, CreateOutputPort,
            UpdateInputPort, UpdateOutputPort, DeleteInputPort, DeleteOutputPort) =
                (listAlbumInputPort, listAlbumOutputPort, createInputPort, createOutputPort,
            updateInputPort, updateOutputPort, deleteInputPort, deleteOutputPort);


        //EndPoint para Obtener Albums
        [HttpGet]
        public async Task<IEnumerable<Album>> GetAlbums()
        {

            await ListAlbumInputPort.GetAlbums();

            var Presenter = ListAlbumOutputPort as ListAlbumPresenter;

            return Presenter.Content;
        }

        //EndPoint para Crear Album
        [HttpPost]
        public async Task<int> Create(FormAlbumRequest request)
        {

            await CreateInputPort.Create(request);
            var Presenter = CreateOutputPort as CreateAlbumPresenter;

            return Presenter.Content;
        }

        //EndPoint para Actualizar Album
        [HttpPut]
        public async Task<int> Update(FormAlbumRequest request)
        {

            await UpdateInputPort.Update(request);
            var Presenter = UpdateOutputPort as UpdateAlbumPresenter;

            return Presenter.Content;
        }

        //EndPoint para borrado lógico Album
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {

            await DeleteInputPort.Delete(id);
            var Presenter = DeleteOutputPort as DeleteAlbumPresenter;

            return Presenter.Content;
        }


    }
}
