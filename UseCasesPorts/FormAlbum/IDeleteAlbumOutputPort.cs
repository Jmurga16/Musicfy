﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCasesPorts.FormAlbum
{
    public interface IDeleteAlbumOutputPort
    {
        Task Handle(int Id);

    }
}
