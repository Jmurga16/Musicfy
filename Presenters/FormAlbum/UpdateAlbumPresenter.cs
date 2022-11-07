using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesPorts.FormAlbum;

namespace Presenters.FormAlbum
{
    public class UpdateAlbumPresenter : IUpdateAlbumOutputPort, IPresenter<int>
    {
        public int Content { get; private set; }

        public Task Handle(int Id)
        {
            Content = Id;
            return Task.CompletedTask;
        }
    }
}
