﻿using EDUEX.Domain;
using System.Collections.Generic;

namespace EDUEX.BL
{
    public interface IWebinarBL : IBaseBL
    {
        Webinar Create(Webinar webinar);

        IList<Webinar> GetAll();

        Webinar GetById(int id);

        Webinar Update(Webinar webinar);

        void Delete(int id);
    }
}
